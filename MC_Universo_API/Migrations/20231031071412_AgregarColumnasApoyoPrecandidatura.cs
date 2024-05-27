using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AgregarColumnasApoyoPrecandidatura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "clave_elector",
                table: "apoyo_precandidatura",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "apoyo_precandidatura",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "numero_telefono",
                table: "apoyo_precandidatura",
                type: "text",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "clave_elector",
                table: "apoyo_precandidatura");

            migrationBuilder.DropColumn(
                name: "email",
                table: "apoyo_precandidatura");

            migrationBuilder.DropColumn(
                name: "numero_telefono",
                table: "apoyo_precandidatura");

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
    }
}
