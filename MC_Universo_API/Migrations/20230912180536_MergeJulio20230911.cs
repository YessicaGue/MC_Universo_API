using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeJulio20230911 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "indice_orden",
                table: "catalogo_etapas_chc",
                type: "integer",
                nullable: true,
                comment: "Indice Orden atributo sirve para ver el orden qe se mostraran las etapas");

            migrationBuilder.AddColumn<string>(
                name: "nombre_url_route",
                table: "catalogo_etapas_chc",
                type: "text",
                nullable: true,
                comment: "Url Pagina es la url de la vista");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_alta", "nombre" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3753), "Requisitos Ciudadanos" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_alta", "nombre" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3759), "Valores y Principios" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3241), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3240), null, null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3247), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3246), null, null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3248), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3248), 1, "Mi camino", "perfil.candidato.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3250), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3250), 2, "Capacitación básica", "capacitacion.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3252), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3251), 4, "Crea tu equipo", "crea.equipo.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3253), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3253), 3, "Tu causa", "causa.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3255), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3254), 6, "Agenda ciudadana", "agenda.ciudadana.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3256), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3256), null, "3 de 3", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3257), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3257), 5, "Ficha territorial", "ficha.territorial.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3259), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3259), 7, "Estrategia política", "5estrategia.politica.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3261), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3261), null, "Agenda de trabajo", null, 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3262), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3262), null, "Ficha y equipo electoral", null, 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 1, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3263), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3263), null, "Perfil del ciudadano", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3265), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3264), null, "Nivel 0", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3266), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3266), null, "Requisitos de elegibilidad", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3267), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3267), 1, "Mi camino", "perfil.candidato.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3269), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3268), 2, "Capacitación básica", "capacitacion.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3270), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3270), 4, "Crea tu equipo", "crea.equipo.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3272), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3271), 3, "Tu causa", "causa.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3273), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3273), 6, "Agenda ciudadana", "agenda.ciudadana.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3274), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3274), null, "3 de 3", null, 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3276), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3275), 5, "Ficha territorial", "ficha.territorial.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3277), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3277), 7, "Estrategia política", "5estrategia.politica.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3279), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3278), null, "Agenda de trabajo", null, 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 2, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3280), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3279), null, "Ficha y equipo electoral", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 2, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3281), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3281), null, "Perfil del ciudadano", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3282), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3282), null, "Nivel 0", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3283), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3283), null, "Requisitos de elegibilidad", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3284), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3284), 1, "Mi camino", "perfil.candidato.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3286), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3286), 2, "Capacitación básica", "capacitacion.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3287), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3287), 4, "Crea tu equipo", "crea.equipo.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3289), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3288), 3, "Tu causa", "causa.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3290), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3290), 6, "Agenda ciudadana", "agenda.ciudadana.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3292), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3292), null, "3 de 3", null, 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3293), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3293), 5, "Ficha territorial", "ficha.territorial.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3294), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3294), 7, "Estrategia política", "5estrategia.politica.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 3, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3296), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3295), null, "Agenda de trabajo", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 3, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3297), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3297), null, "Ficha y equipo electoral", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 3, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3298), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3298), null, "Perfil del ciudadano", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3299), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3299), null, "Requisitos de elegibilidad", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3301), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3300), 1, "Mi camino", "perfil.candidato.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3302), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3302), 2, "Capacitación básica", "capacitacion.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3303), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3303), null, "3 de 3", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3305), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3304), 3, "Tu causa", "causa.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3306), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3306), 4, "Crea tu equipo", "crea.equipo.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3307), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3307), 6, "Agenda ciudadana", "agenda.ciudadana.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3309), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3308), null, "Firmas", null, 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3310), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3310), 5, "Ficha territorial", "ficha.territorial.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 4, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3311), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3311), 7, "Estrategia política", "5estrategia.politica.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 4, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3313), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3312), null, "Agenda de trabajo", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 4, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3314), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3313), null, "Ficha y equipo electoral", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 4, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3340), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3340), null, "Perfil del ciudadano", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3342), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3341), null, "Requisitos de elegibilidad", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3343), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3343), 1, "Mi camino", "perfil.candidato.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3344), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3344), 2, "Capacitación básica", "capacitacion.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3346), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3345), 4, "Crea tu equipo", "crea.equipo.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3347), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3347), 3, "Tu causa", "causa.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3348), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3348), 6, "Agenda ciudadana", "agenda.ciudadana.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3350), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3350), null, "3 de 3", null, 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3351), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3351), null, "Firmas", null, 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 5, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3352), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3352), 5, "Ficha territorial", "ficha.territorial.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 5, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3354), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3353), 7, "Estrategia política", "5estrategia.politica.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 5, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3355), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3355), null, "Agenda de trabajo", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 5, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3356), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3356), null, "Ficha y equipo electoral", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 5, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3358), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3357), null, "Perfil del ciudadano", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3359), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3359), null, "Requisitos de elegibilidad", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3361), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3360), 1, "Mi camino", "perfil.candidato.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3362), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3362), 2, "Capacitación básica", "capacitacion.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3363), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3363), 4, "Crea tu equipo", "crea.equipo.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3365), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3365), 3, "Tu causa", "causa.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3366), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3366), 6, "Agenda ciudadana", "agenda.ciudadana.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3368), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3367), null, "3 de 3", null, 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 6, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3369), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3368), null, "Firmas", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 6, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3370), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3370), 5, "Ficha territorial", "ficha.territorial.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 6, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3371), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3371), 7, "Estrategia política", "5estrategia.politica.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 6, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3373), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3372), null, "Agenda de trabajo", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 6, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3374), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3374), null, "Ficha y equipo electoral", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 6, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3375), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3375), null, "Perfil del ciudadano", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3376), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3376), null, "Requisitos de elegibilidad", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3378), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3377), 1, "Mi camino", "perfil.candidato.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3379), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3379), 2, "Capacitación básica", "capacitacion.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3380), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3380), 4, "Crea tu equipo", "crea.equipo.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3382), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3381), 3, "Tu causa", "causa.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3383), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3383), 6, "Agenda ciudadana", "agenda.ciudadana.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 7, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3384), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3384), null, "3 de 3", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 7, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3386), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3385), null, "Firmas", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 7, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3387), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3387), 5, "Ficha territorial", "ficha.territorial.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 7, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3388), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3388), 7, "Estrategia política", "5estrategia.politica.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 7, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3390), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3389), null, "Agenda de trabajo", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 7, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3391), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3391), null, "Ficha y equipo electoral", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 7, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3392), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3392), null, "Perfil del ciudadano", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3393), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3393), null, "Requisitos de elegibilidad", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3395), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3394), 1, "Mi camino", "perfil.candidato.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3396), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3396), 2, "Capacitación básica", "capacitacion.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3397), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3397), 4, "Crea tu equipo", "crea.equipo.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3399), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3398), 3, "Tu causa", "causa.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 8, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3400), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3400), 6, "Agenda ciudadana", "agenda.ciudadana.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 8, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3401), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3401), null, "3 de 3", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { false, 8, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3403), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3402), null, "Firmas", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 8, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3404), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3403), 5, "Ficha territorial", "ficha.territorial.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 8, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3405), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3405), 7, "Estrategia política", "5estrategia.politica.page" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 8, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3407), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3406), null, "Agenda de trabajo", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 8, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3408), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3407), null, "Ficha y equipo electoral", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route" },
                values: new object[] { 8, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3409), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3409), null, "Perfil del ciudadano", null });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { false, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3410), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3410), null, "Requisitos de elegibilidad", null, 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3411), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3411), 1, "Mi camino", "perfil.candidato.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3413), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3412), 2, "Capacitación básica", "capacitacion.page", 1 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3414), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3414), 4, "Crea tu equipo", "crea.equipo.page", 1 });

            migrationBuilder.InsertData(
                table: "catalogo_etapas_chc",
                columns: new[] { "id", "activo", "camino_id", "descripcion", "fecha_creacion", "fecha_limite", "indice_orden", "nombre", "nombre_url_route", "tipo_etapa_id" },
                values: new object[,]
                {
                    { 109, true, 9, null, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3416), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3415), 3, "Tu causa", "causa.page", 1 },
                    { 110, true, 9, null, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3417), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3417), 6, "Agenda ciudadana", "agenda.ciudadana.page", 1 },
                    { 111, false, 9, null, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3418), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3418), null, "3 de 3", null, 1 },
                    { 112, false, 9, null, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3419), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3419), null, "Firmas", null, 1 },
                    { 113, true, 9, null, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3421), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3420), 5, "Ficha territorial", "ficha.territorial.page", 1 },
                    { 114, true, 9, null, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3422), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3422), 7, "Estrategia política", "5estrategia.politica.page", 1 },
                    { 115, false, 9, null, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3423), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3423), null, "Agenda de trabajo", null, 1 },
                    { 116, false, 9, null, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3425), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3424), null, "Ficha y equipo electoral", null, 1 },
                    { 117, false, 9, null, new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3426), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3426), null, "Perfil del ciudadano", null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2072), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2078), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2079), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2080), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2081), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2082), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2083), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2084), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2086), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2088), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2089), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2090), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2091), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2093), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2094), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2095), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2096), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2097), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2098), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2099), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2100), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2101), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2102), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2104), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2105), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2106), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2107), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2108), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2109), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2110), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2111), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2112), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2160), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2376), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(789), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(794) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DropColumn(
                name: "indice_orden",
                table: "catalogo_etapas_chc");

            migrationBuilder.DropColumn(
                name: "nombre_url_route",
                table: "catalogo_etapas_chc");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_alta", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3647), "Bienvenida 1" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_alta", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3655), "Registro Elegibilidad" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2985), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2992), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2994), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2993), "Capacitación básica" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2995), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2995), "Crea tu equipo" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2997), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2996), "Tu causa" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2999), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2999), "Agenda ciudadana" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3000), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3000), "3 de 3" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3003), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3002), "Ficha territorial" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3004), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3004), "Estrategia política", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3006), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3006), "Agenda de trabajo", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3008), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3007), "Ficha y equipo electoral", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3009), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3009), "Perfil del ciudadano", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 2, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3010), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3010), "Nivel 0" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3012), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3011), "Requisitos de elegibilidad" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3013), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3013), "Capacitación básica" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3014), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3014), "Crea tu equipo" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3015), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3015), "Tu causa" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3018), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3017), "Agenda ciudadana" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3019), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3019), "3 de 3" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3020), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3020), "Ficha territorial" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3022), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3021), "Estrategia política", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3023), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3022), "Agenda de trabajo", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3024), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3024), "Ficha y equipo electoral", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3026), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3025), "Perfil del ciudadano", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 3, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3027), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3027), "Nivel 0" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 3, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3028), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3028), "Requisitos de elegibilidad" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3029), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3029), "Capacitación básica" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3031), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3030), "Crea tu equipo" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3032), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3032), "Tu causa" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3033), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3033), "Agenda ciudadana" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3035), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3034), "3 de 3" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3036), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3036), "Ficha territorial" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3037), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3037), "Estrategia política", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3040), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3040), "Agenda de trabajo", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3041), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3041), "Ficha y equipo electoral", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3043), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3042), "Perfil del ciudadano", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 4, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3044), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3044), "Requisitos de elegibilidad" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 4, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3046), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3045), "Capacitación básica" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 4, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3047), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3047), "3 de 3" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3048), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3048), "Tu causa" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3050), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3049), "Tu causa" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3051), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3051), "Agenda ciudadana" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3052), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3052), "Firmas" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3054), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3053), "Ficha territorial" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3055), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3055), "Estrategia política", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3056), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3056), "Agenda de trabajo", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3058), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3057), "Ficha y equipo electoral", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3060), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3059), "Perfil del ciudadano", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 5, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3061), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3061), "Requisitos de elegibilidad" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 5, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3062), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3062), "Capacitación básica" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 5, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3064), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3063), "Crea tu equipo" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 5, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3065), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3065), "Tu causa" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3066), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3066), "Agenda ciudadana" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3068), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3067), "3 de 3" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3069), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3069), "Firmas" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3070), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3070), "Ficha territorial" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3071), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3071), "Estrategia política", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3073), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3072), "Agenda de trabajo", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3074), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3074), "Ficha y equipo electoral", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3075), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3075), "Perfil del ciudadano", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 6, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3076), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3076), "Requisitos de elegibilidad" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 6, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3078), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3077), "Capacitación básica" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 6, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3079), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3079), "Crea tu equipo" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 6, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3080), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3080), "Tu causa" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 6, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3121), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3121), "Agenda ciudadana" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3125), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3125), "3 de 3" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3127), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3126), "Firmas" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3128), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3128), "Ficha territorial" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3129), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3129), "Estrategia política", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3131), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3130), "Agenda de trabajo", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3132), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3132), "Ficha y equipo electoral", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3133), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3133), "Perfil del ciudadano", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 7, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3135), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3134), "Requisitos de elegibilidad" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 7, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3136), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3136), "Capacitación básica" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 7, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3137), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3137), "Crea tu equipo" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 7, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3139), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3138), "Tu causa" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 7, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3140), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3140), "Agenda ciudadana" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 7, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3141), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3141), "3 de 3" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3142), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3142), "Firmas" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3144), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3143), "Ficha territorial" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3145), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3145), "Estrategia política", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3146), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3146), "Agenda de trabajo", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3148), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3147), "Ficha y equipo electoral", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3149), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3149), "Perfil del ciudadano", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 8, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3150), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3150), "Requisitos de elegibilidad" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 8, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3152), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3151), "Capacitación básica" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 8, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3153), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3152), "Crea tu equipo" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 8, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3155), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3154), "Tu causa" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 8, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3156), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3156), "Agenda ciudadana" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 8, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3157), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3157), "3 de 3" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 8, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3159), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3158), "Firmas" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3160), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3159), "Ficha territorial" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3161), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3161), "Estrategia política", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3163), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3163), "Agenda de trabajo", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3164), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3164), "Ficha y equipo electoral", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3166), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3165), "Perfil del ciudadano", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 9, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3167), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3167), "Requisitos de elegibilidad" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 9, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3168), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3168), "Capacitación básica" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "activo", "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { true, 9, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3170), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3169), "Crea tu equipo" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 9, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3171), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3171), "Tu causa" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 9, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3172), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3172), "Agenda ciudadana" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 9, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3174), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3173), "3 de 3" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 9, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3175), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3175), "Firmas" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "camino_id", "fecha_creacion", "fecha_limite", "nombre" },
                values: new object[] { 9, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3176), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3176), "Ficha territorial" });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "activo", "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { true, new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3177), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3177), "Estrategia política", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3179), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3178), "Agenda de trabajo", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3180), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3180), "Ficha y equipo electoral", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3181), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3181), "Perfil del ciudadano", 2 });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1340), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1346), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1347), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1348), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1350), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1352), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1353), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1355), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1356), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1358), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1359), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1360), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1362), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1363), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1364), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1365), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1367), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1369), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1371), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1372), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1373), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1374), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1375), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1376), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1377), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1379), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1380), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1381), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1382), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1384), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1385), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1386), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1455), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1690), new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 30, 22, 9, 19, 194, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 30, 22, 9, 19, 193, DateTimeKind.Utc).AddTicks(9671), new DateTime(2023, 8, 30, 22, 9, 19, 193, DateTimeKind.Utc).AddTicks(9674) });
        }
    }
}
