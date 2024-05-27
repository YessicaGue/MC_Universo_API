using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AddCirculoFolio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "foto_portada",
                table: "perfil_usuario",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "folio",
                table: "circulo",
                type: "text",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "catalogo_redes_sociales",
                columns: new[] { "id", "activo", "fecha_actualizacion", "fecha_baja", "fecha_creacion", "nombre" },
                values: new object[] { 7, true, new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6886), null, new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(6885), "Conversatorio Grupal Facebook" });

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

            migrationBuilder.InsertData(
                table: "catalogo_tokens",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[] { 4, true, new DateTime(2024, 4, 11, 11, 6, 51, 361, DateTimeKind.Utc).AddTicks(7046), "Facebook personal" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "foto_portada",
                table: "perfil_usuario");

            migrationBuilder.DropColumn(
                name: "folio",
                table: "circulo");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4705), "7h0lje8m" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4722), "kup0demh" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4726), "e03tmycq" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4729), "6eogkdde" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4732), "o4zvclsz" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4736), "n32ekp4b" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4739), "h9j212p7" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3201), "xt1cxds7" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3238), "cmbmpqdu" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3242), "osizk327" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3245), "f92yulde" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3272), "txhgmk8t" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4899), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4907), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4908), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2282), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2290), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2292), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2294), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2296), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2298), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2300), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2302), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2303), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2305), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2307), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2308), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2310), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2313), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2314), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2316), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2318), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2320), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2322), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2323), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2325), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2326), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2328), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2329), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2331), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2332), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2334), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2335), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2337), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2338), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2340), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2343), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2354), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2356), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2358), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2359), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2361), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2362), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2363), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2365), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2366), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2368), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2369), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2371), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2373), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2374), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2376), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2377), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2379), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2380), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2382), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2383), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2384), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2386), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2387), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2389), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2391), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2392), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2394), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2395), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2397), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2398), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2400), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2401), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2403), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2405), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2406), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2408), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2409), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2411), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2413), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2414), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2416), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2417), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2420), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2422), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2423), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2425), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2426), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2428), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2429), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2431), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2432), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2434), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2435), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2437), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2438), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2440), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2441), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2443), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2444), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2445), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2447), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2448), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2452), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2454), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2455), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2456), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2458), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2459), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2470), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2472), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2473), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2475), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2476), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2478), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2479), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2481), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2483), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2484), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2486), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2487), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2489), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2492), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1657), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1663), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1664), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1666), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1667), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1669), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3341), "qla8j3bp" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3349), "mi3dpmpf" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3353), "trgwfbr2" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3356), "s39x1i2i" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3360), "ja4v6stp" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4959), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5020), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5023), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5024), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5188), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5203), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5310), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5320), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5322), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5323), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5324), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5326), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5327), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5328), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5330), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5255), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5261), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5262), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5264), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(286), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(292), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(294), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(295), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(296), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(298), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(299), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(300), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(301), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(303), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(304), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(318), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(319), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(320), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(322), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(323), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(324), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(326), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(327), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(328), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(329), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(331), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(332), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(333), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(334), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(335), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(337), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(338), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(339), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(340), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(341), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(343), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(421), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(711), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 62, DateTimeKind.Utc).AddTicks(8453), new DateTime(2024, 3, 4, 19, 55, 18, 62, DateTimeKind.Utc).AddTicks(8456) });
        }
    }
}
