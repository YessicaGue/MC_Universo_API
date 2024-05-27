using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AgregarColumnaDescripcionEnTablaPerfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "perfil",
                type: "text",
                nullable: true,
                comment: "Esta columna permite describir el perfil como autobiografia");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7391), "t5lsm540" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7401), "bp82pqwl" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7414), "0l5c0iv1" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7417), "klo72cw3" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7419), "7i14omxn" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7422), "hcwqgxbu" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7425), "0qd397xh" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6403), "cqqerzi1" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6428), "cjkw6kya" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6431), "p0sjl342" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6435), "0jlkcm7y" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6449), "7n7su0r6" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7529), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7532), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7534), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5799), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5806), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5808), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5810), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5811), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5813), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5815), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5816), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5817), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5819), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5821), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5822), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5823), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5825), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5826), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5828), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5829), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5831), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5833), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5834), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5835), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5837), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5838), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5839), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5841), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5842), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5843), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5845), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5846), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5847), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5849), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5850), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5852), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5854), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5855), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5857), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5858), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5859), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5861), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5862), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5863), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5864), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5866), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5867), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5869), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5870), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5871), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5873), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5874), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5876), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5877), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5878), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5887), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5889), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5890), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5891), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5893), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5894), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5896), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5897), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5898), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5900), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5901), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5902), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5904), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5906), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5907), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5908), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5910), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5911), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5913), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5914), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5916), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5917), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5918), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5920), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5921), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5923), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5924), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5925), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5927), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5928), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5929), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5931), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5932), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5934), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5935), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5936), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5938), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5939), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5940), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5941), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5943), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5944), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5946), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5947), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5949), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5950), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5951), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5953), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5954), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5955), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5957), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5958), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5959), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5960), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5962), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5963), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5965), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5966), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5968), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5969), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5970), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5971), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5973), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5974), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5975), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6485), "m48kp16k" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6492), "q3cmg4s8" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6495), "8on2cwv4" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6498), "q7s2y62i" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6502), "cnubnj56" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7566), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7592), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7596), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7597), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7630), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7634), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7687), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7691), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7692), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7659), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7661), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7662), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7663), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4630), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4636), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4637), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4639), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4640), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4641), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4642), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4644), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4645), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4646), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4647), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4655), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4656), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4657), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4658), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4659), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4661), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4662), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4663), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4664), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4665), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4666), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4667), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4668), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4671), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4672), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4673), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4674), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4675), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4676), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4677), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4678), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4712), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4987), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(3482), new DateTime(2023, 10, 31, 3, 18, 46, 871, DateTimeKind.Utc).AddTicks(3487) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "perfil");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5137), "j6lg63ru" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5149), "yml0bqg9" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5151), "jft61kaq" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5154), "sgtnnyd2" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5157), "vqvocjnz" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5159), "cl4n7fyj" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5162), "hsj1bhyr" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4089), "y794ymkf" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4121), "rkxurz2j" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4124), "pv9oozph" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4127), "yzd1spuk" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4138), "g901jwq6" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5280), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5284), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5285), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3485), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3492), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3494), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3496), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3497), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3499), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3501), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3502), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3503), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3505), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3506), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3508), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3509), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3510), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3511), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3512), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3514), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3515), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3517), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3518), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3520), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3521), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3522), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3523), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3525), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3526), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3527), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3528), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3529), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3531), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3532), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3533), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3535), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3544), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3545), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3547), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3548), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3549), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3551), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3552), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3553), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3554), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3556), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3557), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3558), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3560), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3561), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3562), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3564), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3565), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3566), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3567), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3569), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3570), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3571), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3572), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3574), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3575), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3576), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3578), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3579), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3580), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3582), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3583), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3584), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3586), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3587), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3588), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3590), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3591), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3592), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3594), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3595), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3596), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3597), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3599), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3600), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3601), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3602), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3604), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3605), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3606), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3608), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3609), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3610), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3612), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3613), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3614), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3615), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3617), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3618), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3619), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3620), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3622), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3623), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3624), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3626), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3627), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3628), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3629), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3631), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3632), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3633), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3642), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3643), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3644), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3645), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3647), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3648), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3649), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3651), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3652), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3653), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3655), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3656), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3657), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3658), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4203), "cifz4hdh" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4211), "4pvqga9e" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4214), "xlz2pd3o" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4222), "mcuzkvzz" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4224), "c8kikr50" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5321), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5345), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5350), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5351), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5396), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5401), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5450), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5453), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5455), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5419), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5422), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5423), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5424), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2389), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2394), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2395), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2396), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2397), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2399), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2400), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2401), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2402), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2404), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2405), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2406), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2407), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2408), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2409), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2410), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2411), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2412), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2413), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2414), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2415), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2416), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2417), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2418), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2419), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2420), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2421), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2422), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2423), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2424), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2425), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2426), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2467), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2757), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(1163), new DateTime(2023, 10, 30, 20, 59, 56, 16, DateTimeKind.Utc).AddTicks(1168) });
        }
    }
}
