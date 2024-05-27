using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class CambiosTablaPerfilInvitacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_perfil_invitacion_circulo_perfil_perfil_anfitrion_id",
                table: "perfil_invitacion_circulo");

            migrationBuilder.AlterColumn<int>(
                name: "perfil_anfitrion_id",
                table: "perfil_invitacion_circulo",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "usuario_invitacion_id",
                table: "perfil_invitacion_circulo",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5362), "xr1ik4o2" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5394), "dgulghvl" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5398), "y7ccvww8" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5401), "xkwj0pnu" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5404), "n15mja41" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5407), "sb7bdi1a" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5410), "qy2p2ir1" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2802), "g1y358c8" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2863), "i2hatazg" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2867), "fdxklun3" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2871), "1bem3h7q" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2937), "bz8ymhu3" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5739), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5741), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8563), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8579), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8582), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8584), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8589), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8592), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8594), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8595), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8597), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8599), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8601), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8602), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8603), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8605), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8606), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8607), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8609), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8611), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8613), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8615), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8616), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8636), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8638), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8640), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8641), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8642), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8644), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8645), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8647), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8648), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8650), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8651), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8653), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8655), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8657), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8659), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8660), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8661), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8663), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8664), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8666), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8667), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8669), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8670), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8672), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8673), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8675), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8676), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8678), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8680), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8681), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8683), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8684), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8686), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8689), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8691), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8692), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8694), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8696), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8697), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8699), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8700), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8701), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8703), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8705), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8706), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8708), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8709), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8711), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8712), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8714), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8715), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8717), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8718), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8720), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8721), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8722), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8724), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8725), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8727), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8728), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8730), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8732), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8733), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8735), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8736), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8738), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8739), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8741), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8755), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8756), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8758), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8760), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8761), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8763), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8764), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8766), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8767), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8769), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8771), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8772), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8773), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8775), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8776), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8778), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8779), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8781), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8782), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8784), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8785), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8787), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8788), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8790), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8791), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8793), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8794), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6946), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7021), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7025), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7028), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7034), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3109), "hkammwqh" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3129), "79u8c2bf" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3134), "zdii5f8x" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3138), "92ujsd5t" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3141), "ldsvv01i" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5867), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6007), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6023), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6024), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6125), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6133), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6711), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6730), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6731), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6732), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6735), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6739), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6740), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6741), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6742), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6571), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6591), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6592), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6593), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4759), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4771), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4772), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4773), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4775), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4777), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4778), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4779), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4780), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4782), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4783), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4785), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4786), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4787), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4788), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4789), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4791), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4792), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4794), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4795), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4796), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4797), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4798), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4799), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4801), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4802), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4803), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4804), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4805), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4807), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4808), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4809), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4933), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5246), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(2589), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.AddForeignKey(
                name: "fk_perfil_invitacion_circulo_perfil_perfil_anfitrion_id",
                table: "perfil_invitacion_circulo",
                column: "perfil_anfitrion_id",
                principalTable: "perfil",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_perfil_invitacion_circulo_perfil_perfil_anfitrion_id",
                table: "perfil_invitacion_circulo");

            migrationBuilder.DropColumn(
                name: "usuario_invitacion_id",
                table: "perfil_invitacion_circulo");

            migrationBuilder.AlterColumn<int>(
                name: "perfil_anfitrion_id",
                table: "perfil_invitacion_circulo",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3350), "p8y5w6yc" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3362), "h57s5kn1" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3366), "x2ni22fr" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3369), "m995rccj" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3372), "bk6p1c8y" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3375), "7byt9bif" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3378), "wdi1mcq6" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2241), "z8z2c7jo" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2264), "v2by7obn" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2268), "mvkxavns" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2271), "2ypofdyo" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2293), "e359hzxh" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3505), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3510), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3511), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1535), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1541), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1543), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1544), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1546), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1548), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1549), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1550), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1552), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1554), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1555), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1556), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1557), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1559), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1560), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1561), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1563), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1564), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1566), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1567), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1569), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1570), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1571), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1573), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1574), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1575), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1576), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1578), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1579), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1580), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1582), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1583), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1584), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1592), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1594), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1595), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1596), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1598), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1599), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1601), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1603), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1604), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1605), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1607), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1608), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1610), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1611), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1612), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1614), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1615), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1616), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1617), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1618), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1621), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1623), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1624), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1625), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1627), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1628), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1629), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1631), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1632), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1633), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1635), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1636), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1638), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1639), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1640), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1642), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1643), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1645), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1646), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1647), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1649), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1650), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1651), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1652), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1654), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1655), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1656), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1658), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1659), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1661), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1662), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1663), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1664), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1666), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1667), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1668), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1671), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1672), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1674), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1675), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1677), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1678), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1679), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1680), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1682), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1683), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1685), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1691), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1692), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1693), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1695), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1696), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1698), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1699), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1700), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1702), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1703), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1704), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1706), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1707), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1708), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1146), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1149), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1150), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1151), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1152), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1153), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2333), "a7qfx5g3" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2342), "ahdg39z3" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2345), "79rqjx25" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2348), "uj411ppz" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2351), "cg5x7e4z" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3542), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3585), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3589), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3590), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3622), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3627), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3832), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3836), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3837), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3838), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3841), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3842), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3843), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3844), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3790), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3794), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3795), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3796), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(218), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(222), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(223), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(224), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(226), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(227), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(228), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(231), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(232), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(249), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(263), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(264), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(265), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(267), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(268), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(269), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(270), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(271), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(272), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(273), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(274), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(275), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(276), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(277), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(278), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(279), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(280), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(281), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(282), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(283), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(284), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(338), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(600), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 311, DateTimeKind.Utc).AddTicks(8860), new DateTime(2024, 2, 20, 6, 50, 19, 311, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.AddForeignKey(
                name: "fk_perfil_invitacion_circulo_perfil_perfil_anfitrion_id",
                table: "perfil_invitacion_circulo",
                column: "perfil_anfitrion_id",
                principalTable: "perfil",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
