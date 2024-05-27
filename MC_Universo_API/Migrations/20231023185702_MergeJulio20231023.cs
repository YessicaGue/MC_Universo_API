using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeJulio20231023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cantidad_migrantes",
                table: "requisito_por_circunscripcion",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_nacimiento",
                table: "persona",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "formulas_representacion_proporcional",
                table: "detalle_requisito_diputaciones",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "candidatos_senador_representacion_proporcional",
                table: "detalle_requisito_diputaciones",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "candidatos_senador_primera_minoria",
                table: "detalle_requisito_diputaciones",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "candidatos_senador_mayoria_relativa",
                table: "detalle_requisito_diputaciones",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "numero_lista",
                table: "candidatos_chc",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "persona_adulto_mayor",
                table: "candidatos_chc",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "persona_joven",
                table: "candidatos_chc",
                type: "boolean",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5883), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5887), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5889), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4298), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4310), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4311), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4313), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4314), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4316), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4318), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4319), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4320), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4322), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4324), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4327), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4328), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4329), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4330), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4332), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4334), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4335), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4337), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4338), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4339), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4341), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4342), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4343), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4344), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4346), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4347), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4348), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4349), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4351), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4352), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4354), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4361), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4362), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4364), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4365), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4366), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4368), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4369), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4370), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4371), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4373), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4374), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4375), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4377), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4378), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4379), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4381), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4382), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4383), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4385), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4386), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4387), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4389), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4390), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4391), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4393), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4394), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4395), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4397), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4398), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4399), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4401), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4402), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4404), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4405), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4407), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4408), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4410), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4411), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4412), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4414), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4415), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4416), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4418), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4419), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4420), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4421), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4422), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4424), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4425), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4427), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4428), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4430), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4431), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4432), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4433), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4435), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4436), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4437), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4438), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4440), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4441), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4443), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4444), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4445), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4447), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4448), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4449), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4451), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4452), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4453), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4455), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4471), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4472), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4473), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4475), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4476), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4478), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4479), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4480), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4481), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4483), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4484), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4485), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4487), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.InsertData(
                table: "catalogo_publicaciones",
                columns: new[] { "id", "fecha_creacion", "nombre" },
                values: new object[] { 4, new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3829), "Apoyo precandidatura" });

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5922), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5978), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5986), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5988), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6018), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6022), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6086), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6090), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6091), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6053), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6058), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6059), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6060), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "candidatos_totales", "cantidad_hombres", "cantidad_mujeres", "fecha_creacion" },
                values: new object[] { 32, 16, 16, new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "candidatos_totales", "cantidad_hombres", "cantidad_mujeres", "fecha_creacion" },
                values: new object[] { 64, 32, 32, new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3060), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3066), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3067), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3068), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3069), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3071), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3072), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3073), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3074), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3076), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3077), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3084), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3085), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3086), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3088), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3089), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3090), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3091), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3092), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3093), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3094), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3095), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3096), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3097), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3098), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3100), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3101), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3102), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3103), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3104), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3105), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3106), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3156), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3420), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "cantidad_migrantes", "fecha_creacion" },
                values: new object[] { 1, new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "cantidad_migrantes", "fecha_creacion" },
                values: new object[] { 1, new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "cantidad_migrantes", "fecha_creacion" },
                values: new object[] { 1, new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "cantidad_migrantes", "fecha_creacion" },
                values: new object[] { 1, new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "cantidad_migrantes", "fecha_creacion" },
                values: new object[] { 1, new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(1705), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(1710) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "cantidad_migrantes",
                table: "requisito_por_circunscripcion");

            migrationBuilder.DropColumn(
                name: "numero_lista",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "persona_adulto_mayor",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "persona_joven",
                table: "candidatos_chc");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_nacimiento",
                table: "persona",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "formulas_representacion_proporcional",
                table: "detalle_requisito_diputaciones",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "candidatos_senador_representacion_proporcional",
                table: "detalle_requisito_diputaciones",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "candidatos_senador_primera_minoria",
                table: "detalle_requisito_diputaciones",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "candidatos_senador_mayoria_relativa",
                table: "detalle_requisito_diputaciones",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1109), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1117), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1118), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9522), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9529), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9531), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9533), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9534), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9537), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9538), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9546), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9547), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9549), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9551), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9552), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9553), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9554), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9556), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9557), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9558), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9561), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9563), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9564), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9565), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9567), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9568), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9571), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9572), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9573), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9574), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9576), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9577), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9579), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9582), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9583), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9584), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9586), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9587), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9588), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9591), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9592), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9594), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9595), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9596), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9597), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9599), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9600), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9601), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9603), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9604), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9605), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9606), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9608), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9609), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9610), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9612), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9613), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9615), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9616), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9617), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9618), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9621), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9622), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9624), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9625), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9627), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9628), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9629), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9631), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9632), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9639), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9642), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9643), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9644), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9646), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9647), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9648), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9649), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9651), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9652), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9653), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9655), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9656), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9657), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9659), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9660), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9661), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9662), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9664), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9665), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9666), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9668), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9669), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9670), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9672), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9673), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9674), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9676), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9677), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9678), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9679), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9681), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9682), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9683), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9685), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9686), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9687), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9689), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9690), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9691), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9693), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9694), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9695), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9696), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1157), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1189), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1194), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1195), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1232), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1236), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1302), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1306), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1307), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1264), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1268), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1269), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1271), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "candidatos_totales", "cantidad_hombres", "cantidad_mujeres", "fecha_creacion" },
                values: new object[] { 64, 32, 32, new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "candidatos_totales", "cantidad_hombres", "cantidad_mujeres", "fecha_creacion" },
                values: new object[] { 32, 16, 16, new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8301), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8306), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8308), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8309), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8310), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8312), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8313), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8314), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8315), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8316), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8317), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8331), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8332), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8333), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8334), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8340), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8343), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8344), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8346), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8347), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8348), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8349), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8350), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8351), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8353), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8354), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8355), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8356), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8357), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8358), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8359), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8360), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8403), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8683), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(7005), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(7009) });
        }
    }
}
