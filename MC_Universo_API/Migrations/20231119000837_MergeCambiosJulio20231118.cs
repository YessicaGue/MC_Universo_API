using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeCambiosJulio20231118 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "es_visible",
                table: "publicacion",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "confirmacion_registro",
                table: "apoyo_precandidatura",
                type: "boolean",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9474), "wp4wrcub" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9488), "mglcm6w1" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9491), "1klwlpko" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9494), "z4flh8be" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9497), "63aip27k" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9500), "3o3d1rsj" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9503), "d0wneyfo" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8469), "at7c6g2d" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8493), "6mz1bvw2" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8496), "jor9y3zq" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8506), "pwkgjfkd" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8516), "4ot3tjzu" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9632), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9637), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9638), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7852), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7862), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7863), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7865), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7866), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7868), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7870), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7871), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7873), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7875), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7876), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7877), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7879), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7880), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7881), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7882), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7884), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7885), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7887), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7888), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7889), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7891), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7892), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7893), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7895), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7896), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7897), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7898), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7900), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7901), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7902), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7904), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7905), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7907), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7908), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7910), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7911), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7912), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7913), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7915), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7916), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7917), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7918), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7920), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7921), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7922), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7924), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7925), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7926), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7928), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7929), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7930), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7931), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7933), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7934), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7935), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7937), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7938), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7939), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7941), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7942), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7943), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7945), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7946), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7947), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7955), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7956), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7957), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7959), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7960), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7961), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7963), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7964), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7965), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7967), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7968), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7969), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7970), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7972), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7973), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7974), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7976), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7977), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7978), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7980), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7981), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7982), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7983), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7985), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7986), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7987), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7988), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7990), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7991), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7992), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7994), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7995), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7997), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7998), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7999), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8000), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8002), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8003), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8004), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8005), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8007), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8008), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8009), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8011), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8012), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8013), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8015), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8016), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8017), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8019), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8020), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8021), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8556), "im23av4v" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8564), "07ezb5pn" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8567), "op0kbjfz" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8571), "ievceucd" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8574), "jeiek7m5" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9675), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9706), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9709), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9710), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9741), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9746), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9817), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9821), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9822), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9823), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9824), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9825), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9826), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9827), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9828), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9777), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9782), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9782), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6647), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6652), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6654), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6655), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6656), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6657), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6658), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6659), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6660), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6662), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6664), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6670), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6671), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6672), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6673), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6674), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6675), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6676), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6677), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6678), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6679), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6680), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6681), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6682), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6683), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6684), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6685), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6686), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6688), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6689), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6690), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6691), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6733), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6999), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(5341), new DateTime(2023, 11, 19, 0, 8, 36, 544, DateTimeKind.Utc).AddTicks(5346) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "es_visible",
                table: "publicacion");

            migrationBuilder.DropColumn(
                name: "confirmacion_registro",
                table: "apoyo_precandidatura");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3989), "lmy75iyg" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3998), "m5dpcfsb" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4001), "afexc2tg" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4004), "2hm37cqb" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4007), "dwj1c3qu" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4010), "5zedujzp" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4012), "enye2sf8" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2820), "199fuoi1" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2845), "9ukqrjc9" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2848), "c5mz1l1g" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2851), "r858sryt" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2869), "qraj4byu" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4116), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4122), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4123), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2154), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2167), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2168), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2171), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2172), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2174), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2176), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2177), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2178), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2180), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2181), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2183), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2184), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2185), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2186), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2187), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2189), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2190), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2192), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2193), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2194), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2196), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2197), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2198), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2199), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2201), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2202), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2203), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2204), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2206), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2207), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2208), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2210), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2212), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2213), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2214), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2247), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2249), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2250), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2251), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2252), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2254), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2255), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2256), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2258), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2259), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2261), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2262), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2263), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2264), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2266), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2267), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2268), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2269), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2271), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2272), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2273), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2275), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2276), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2277), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2278), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2280), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2281), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2282), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2284), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2285), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2287), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2288), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2289), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2291), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2292), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2293), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2295), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2296), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2297), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2299), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2300), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2301), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2302), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2303), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2305), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2306), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2307), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2309), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2310), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2311), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2313), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2314), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2315), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2317), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2318), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2319), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2320), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2321), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2323), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2324), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2326), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2327), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2328), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2329), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2331), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2332), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2333), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2334), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2336), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2337), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2338), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2340), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2341), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2342), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2371), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2372), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2374), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2375), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2376), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2378), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2379), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2897), "lsu5qias" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2903), "m1euzera" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2906), "hfffbyku" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2909), "32i8u6s5" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2912), "gck2okm2" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4151), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4172), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4176), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4177), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4205), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4211), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4314), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4319), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4320), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4321), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4322), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4323), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4324), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4326), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4231), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4285), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4286), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4287), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(973), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(980), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(981), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(982), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(983), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(985), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(986), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(989), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(990), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(991), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(992), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(994), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(995), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(996), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(997), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(998), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(999), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1000), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1001), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1003), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1004), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1005), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1006), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1007), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1008), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1009), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1010), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1011), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1012), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1013), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1014), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1015), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1048), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1336), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 404, DateTimeKind.Utc).AddTicks(9750), new DateTime(2023, 11, 7, 4, 39, 24, 404, DateTimeKind.Utc).AddTicks(9755) });
        }
    }
}
