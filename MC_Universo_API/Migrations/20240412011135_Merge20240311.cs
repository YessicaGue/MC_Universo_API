using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class Merge20240311 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "es_general",
                table: "causa",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_creacion",
                table: "causa",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_eliminacion",
                table: "causa",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_modificacion",
                table: "causa",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9773), "4wm7ex30" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9795), "ha8qrugq" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9798), "7yl5ggwa" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9801), "ezmnlsu0" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9805), "cjw4oab8" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9808), "q8l1glny" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9811), "m88k64g3" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7936), "zy7wrihx" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7969), "cudxaz0o" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7973), "druykgj6" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7977), "eb4atey6" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8026), "xwkdu4ok" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(35), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(55), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(57), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6772), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6789), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6791), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6794), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6796), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6799), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6800), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6802), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6804), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6806), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6807), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6809), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6810), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6812), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6813), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6815), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6817), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6819), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6820), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6822), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6824), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6825), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6827), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6829), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6830), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6832), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6833), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6835), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6836), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6838), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6841), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6842), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6846), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6848), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6850), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6851), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6853), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6855), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6856), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6857), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6859), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6860), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6862), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6863), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6865), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6867), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6868), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6870), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6871), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6873), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6875), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6876), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6878), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6879), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6881), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6884), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6886), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6888), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6889), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6890), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6892), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6893), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6895), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6896), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6907), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6909), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6911), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6913), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6914), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6916), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6917), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6919), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6920), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6922), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6924), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6926), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6929), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6931), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6933), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6934), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6936), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6938), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6939), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6941), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6942), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6944), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6946), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6947), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6949), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6950), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6952), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6953), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6955), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6956), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6958), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6960), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6961), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6963), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6964), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6968), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6969), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6971), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6972), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6977), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6978), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6980), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6981), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6983), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6984), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6986), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6988), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6989), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6991), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5960), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5972), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5973), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5974), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5975), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5977), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5978), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8107), "4dco4o26" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8124), "npfv52x2" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8128), "z9p6yqws" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8132), "lluvllad" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8135), "pam2o1pn" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(130), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(205), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(212), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(213), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(502), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(517), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(672), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(684), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(686), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(687), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(688), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(690), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(691), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(692), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(704), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(582), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(593), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(594), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(595), new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "es_general", "fecha_creacion", "fecha_eliminacion", "fecha_modificacion" },
                values: new object[] { false, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5537), null, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "es_general", "fecha_creacion", "fecha_eliminacion", "fecha_modificacion" },
                values: new object[] { false, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5548), null, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "es_general", "fecha_creacion", "fecha_eliminacion", "fecha_modificacion" },
                values: new object[] { false, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5549), null, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "es_general", "fecha_creacion", "fecha_eliminacion", "fecha_modificacion" },
                values: new object[] { false, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5551), null, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "es_general", "fecha_creacion", "fecha_eliminacion", "fecha_modificacion" },
                values: new object[] { false, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5552), null, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "es_general", "fecha_creacion", "fecha_eliminacion", "fecha_modificacion" },
                values: new object[] { false, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5554), null, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "es_general", "fecha_creacion", "fecha_eliminacion", "fecha_modificacion" },
                values: new object[] { false, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5555), null, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "es_general", "fecha_creacion", "fecha_eliminacion", "fecha_modificacion" },
                values: new object[] { false, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5557), null, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "es_general", "fecha_creacion", "fecha_eliminacion", "fecha_modificacion" },
                values: new object[] { false, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5558), null, new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4330), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4349), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4351), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4363), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4364), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4366), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4368), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4369), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4370), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4372), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4373), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4383), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4385), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4386), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4387), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4388), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4390), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4392), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4393), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4394), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4396), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4397), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4398), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4400), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4401), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4402), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4403), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4405), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4406), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4407), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4409), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4410), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4517), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4856), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 46, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(2286), new DateTime(2024, 4, 12, 1, 11, 33, 45, DateTimeKind.Utc).AddTicks(2288) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "es_general",
                table: "causa");

            migrationBuilder.DropColumn(
                name: "fecha_creacion",
                table: "causa");

            migrationBuilder.DropColumn(
                name: "fecha_eliminacion",
                table: "causa");

            migrationBuilder.DropColumn(
                name: "fecha_modificacion",
                table: "causa");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9219), "dujyu9uj" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9234), "2anqgwcs" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9236), "2em2h3cg" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9238), "nzdc3nfq" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9240), "ltr1g80j" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9243), "f970xc9p" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9245), "2wn6ncw8" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 362, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 362, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 362, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8011), "sdtdevm3" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8043), "ulbw0524" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8045), "ggrpbbd7" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8048), "s3zk5dd3" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8072), "76iksimb" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9386), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9392), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9393), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7298), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7304), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7306), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7308), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7310), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7312), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7314), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7315), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7316), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7318), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7320), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7326), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7327), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7328), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7330), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7331), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7332), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7334), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7335), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7337), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7338), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7339), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7341), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7342), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7343), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7345), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7346), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7347), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7348), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7350), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7351), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7352), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7354), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7356), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7357), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7359), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7360), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7361), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7363), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7364), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7365), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7366), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7368), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7369), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7370), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7372), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7373), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7374), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7376), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7377), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7378), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7380), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7381), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7382), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7383), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7385), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7386), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7388), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7389), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7391), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7392), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7393), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7395), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7396), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7397), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7399), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7400), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7402), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7403), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7404), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7406), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7407), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7408), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7410), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7411), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7412), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7414), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7420), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7422), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7423), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7424), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7426), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7427), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7429), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7430), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7431), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7433), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7434), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7435), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7437), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7438), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7439), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7440), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7442), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7443), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7445), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7446), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7447), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7449), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7450), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7451), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7453), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7454), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7455), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7456), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7458), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7459), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7461), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7462), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7463), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7465), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7466), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7467), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7469), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7470), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7471), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7472), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6876), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6880), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6881), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6883), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6885), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6886), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8124), "wyvcu4b6" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8131), "3knwjqf6" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8134), "6gdcotdm" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8136), "270d8ye1" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8139), "jtm8qfuy" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9438), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9486), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9488), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9490), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9651), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9655), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9746), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9751), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9753), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9754), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9754), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9756), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9757), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9758), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9765), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9699), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9704), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9706), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9707), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5890), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5895), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5896), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5897), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5899), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5900), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5901), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5903), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5904), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5905), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5906), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5916), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5917), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5918), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5919), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5920), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5921), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5923), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5924), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5925), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5926), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5927), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5928), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5929), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5930), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5931), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5938), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5939), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5941), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5942), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5943), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5998), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6250), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(4389), new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(4393) });
        }
    }
}
