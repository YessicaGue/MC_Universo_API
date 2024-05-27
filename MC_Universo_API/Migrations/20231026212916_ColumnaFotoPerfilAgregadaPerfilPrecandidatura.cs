using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class ColumnaFotoPerfilAgregadaPerfilPrecandidatura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "foto_perfil",
                table: "perfil_precandidatura",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4296), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4304), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4305), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2549), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2568), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2569), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2571), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2573), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2574), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2577), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2578), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2580), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2581), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2583), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2584), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2585), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2587), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2588), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2589), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2591), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2592), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2594), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2595), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2597), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2598), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2599), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2601), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2602), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2603), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2604), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2606), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2607), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2608), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2610), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2611), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2612), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2614), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2616), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2617), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2618), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2620), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2621), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2622), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2623), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2625), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2626), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2627), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2629), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2630), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2631), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2633), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2634), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2636), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2637), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2638), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2645), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2646), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2647), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2649), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2650), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2652), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2653), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2654), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2655), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2657), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2658), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2659), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2661), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2662), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2664), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2665), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2666), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2668), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2669), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2671), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2672), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2673), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2675), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2676), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2677), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2678), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2680), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2681), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2682), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2684), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2685), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2687), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2688), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2689), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2690), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2692), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2693), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2694), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2696), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2697), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2698), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2700), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2701), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2702), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2704), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2705), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2706), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2707), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2709), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2710), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2712), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2713), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2714), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2715), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2717), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2718), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2719), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2721), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2722), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2723), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2725), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2726), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2727), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2729), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2730), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4337), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4371), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4380), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4381), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4409), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4421), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4482), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4499), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4500), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4444), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4452), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4453), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4454), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1259), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1270), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1272), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1273), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1274), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1275), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1276), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1277), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1278), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1280), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1281), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1289), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1290), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1291), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1292), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1293), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1295), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1296), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1297), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1298), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1299), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1300), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1301), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1302), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1303), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1304), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1306), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1307), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1308), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1309), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1310), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1311), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1346), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1630), new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 21, 29, 15, 204, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 21, 29, 15, 203, DateTimeKind.Utc).AddTicks(9918), new DateTime(2023, 10, 26, 21, 29, 15, 203, DateTimeKind.Utc).AddTicks(9922) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "foto_perfil",
                table: "perfil_precandidatura");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5057), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5061), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5062), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3298), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3304), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3306), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3308), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3309), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3311), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3313), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3314), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3316), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3318), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3319), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3321), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3322), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3323), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3324), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3326), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3327), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3329), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3330), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3332), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3333), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3334), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3336), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3337), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3338), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3340), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3341), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3342), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3343), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3345), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3346), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3347), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3349), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3351), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3352), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3354), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3355), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3356), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3357), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3359), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3360), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3361), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3363), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3364), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3366), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3367), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3368), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3370), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3371), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3372), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3374), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3375), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3376), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3377), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3379), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3380), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3381), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3389), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3390), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3392), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3393), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3394), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3396), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3397), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3398), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3401), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3402), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3403), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3405), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3406), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3407), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3409), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3410), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3411), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3413), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3414), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3415), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3416), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3418), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3419), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3420), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3422), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3423), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3424), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3426), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3427), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3428), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3430), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3431), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3432), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3433), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3435), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3436), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3437), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3439), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3440), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3441), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3443), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3444), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3446), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3447), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3448), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3450), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3451), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3452), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3453), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3455), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3456), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3457), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3459), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3460), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3461), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3463), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3464), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3465), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3467), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3468), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5102), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5138), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5141), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5142), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5172), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5177), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5237), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5240), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5241), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5199), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5208), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5210), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5211), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1512), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1521), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1522), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1523), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1524), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1527), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1528), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1530), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1531), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1533), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1535), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1550), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1551), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1553), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1555), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1556), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1557), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1561), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1562), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1563), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1565), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1571), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1573), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1574), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1576), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1577), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1578), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1580), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1582), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1583), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1584), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1647), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2023), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 901, DateTimeKind.Utc).AddTicks(9824), new DateTime(2023, 10, 26, 6, 47, 53, 901, DateTimeKind.Utc).AddTicks(9828) });
        }
    }
}
