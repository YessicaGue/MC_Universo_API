using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class ColumnaPeriodicidadAgregadaTablaComision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "periodicidad",
                table: "comision",
                type: "text",
                nullable: false,
                defaultValue: "",
                comment: "Esta columna almacena las periodicidades de sesiones, siendo la cantidad de sesiones por cada dia o mes o anio para los diferentes sus diferentes tipos");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "periodicidad",
                table: "comision");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1592), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1600), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1601), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(260), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(267), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(269), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(272), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(273), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(275), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(277), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(278), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(279), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(281), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(282), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(283), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(285), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(286), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(287), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(288), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(290), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(291), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(293), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(294), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(296), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(297), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(298), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(299), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(301), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(302), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(303), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(304), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(329), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(330), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(332), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(333), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(334), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(336), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(338), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(339), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(340), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(341), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(343), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(344), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(345), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(346), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(348), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(349), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(350), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(352), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(353), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(354), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(356), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(357), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(358), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(360), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(361), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(362), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(363), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(365), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(366), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(367), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(369), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(370), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(371), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(372), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(374), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(375), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(376), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(378), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(379), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(381), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(382), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(384), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(385), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(386), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(387), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(389), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(390), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(391), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(393), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(394), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(395), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(396), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(398), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(399), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(400), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(402), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(403), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(404), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(405), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(407), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(408), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(409), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(411), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(412), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(413), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(414), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(416), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(417), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(418), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(441), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(442), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(443), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(445), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(446), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(447), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(449), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(450), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(451), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(452), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(454), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(455), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(456), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(458), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(459), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(460), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(462), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(463), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(464), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(465), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1628), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1647), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1651), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1652), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1679), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1683), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1732), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1742), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1743), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1702), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1706), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1707), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1708), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9181), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9185), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9187), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9188), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9189), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9191), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9192), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9193), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9194), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9195), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9196), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9198), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9199), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9201), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9202), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9203), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9205), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9206), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9207), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9208), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9209), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9210), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9211), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9212), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9213), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9214), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9215), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9216), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9217), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9218), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9219), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9259), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(7782), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(7786) });
        }
    }
}
