using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeJulio20230811 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_persona_genero_genero_id",
                table: "persona");

            migrationBuilder.RenameColumn(
                name: "apodo",
                table: "persona",
                newName: "seudonimo");

            migrationBuilder.AlterColumn<int>(
                name: "genero_id",
                table: "persona",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "correo_electronico",
                table: "persona",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "entidad_federativa_id",
                table: "persona",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "telefono_particular",
                table: "persona",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "tiempo_residencia",
                table: "persona",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5173), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5179), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5180), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5182), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5183), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5185), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5187), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5188), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5189), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5191), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5193), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5194), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5195), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5197), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5198), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5199), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5201), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5203), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5204), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5205), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5207), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5208), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5209), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5211), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5212), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5213), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5215), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5216), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5218), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5219), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5220), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5222), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5223), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5225), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5227), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5228), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5230), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5231), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5232), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5234), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5235), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5236), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5238), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5239), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5240), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5242), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5243), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5245), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5246), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5247), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5249), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5250), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5251), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5253), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5254), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5256), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5257), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5258), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5260), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5261), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5262), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5264), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5265), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5266), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5268), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5270), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5271), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5273), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5274), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5333), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5335), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5336), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5337), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5339), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5341), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5343), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5344), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5345), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5347), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5348), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5349), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5351), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5352), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5353), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5355), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5356), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5357), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5359), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5360), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5362), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5363), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5364), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5366), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5367), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5368), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5370), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5371), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5372), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5374), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5375), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5376), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5378), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5379), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5381), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5382), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5383), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5385), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3739), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3754), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3756), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3757), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3759), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3760), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3762), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3763), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3764), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3767), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3768), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3769), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3771), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3772), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3773), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3774), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3776), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3777), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3779), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3780), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3782), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3783), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3784), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3786), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3787), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3787) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3788), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3790), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3791), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3792), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3794), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3795), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3796), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "correo_electronico", "entidad_federativa_id", "fecha_creacion", "fecha_modificacion", "genero_id", "seudonimo", "telefono_particular", "tiempo_residencia" },
                values: new object[] { "coeto@gmail.com", 1, new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3861), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3861), 1, "Coeto", "+525555555555", 1 });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "correo_electronico", "entidad_federativa_id", "fecha_creacion", "fecha_modificacion", "genero_id", "seudonimo", "telefono_particular", "tiempo_residencia" },
                values: new object[] { "naranja@gmail.com", 1, new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4124), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4124), 1, "Naranja", "+529999999999", 2 });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(1876), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.CreateIndex(
                name: "ix_persona_entidad_federativa_id",
                table: "persona",
                column: "entidad_federativa_id");

            //migrationBuilder.AddForeignKey(
            //    name: "fk_persona_entidad_federativa_entidad_federativa_id",
            //    table: "persona",
            //    column: "entidad_federativa_id",
            //    principalTable: "entidad_federativa",
            //    principalColumn: "id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "fk_persona_genero_genero_id",
            //    table: "persona",
            //    column: "genero_id",
            //    principalTable: "genero",
            //    principalColumn: "id",
            //    onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_persona_entidad_federativa_entidad_federativa_id",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "fk_persona_genero_genero_id",
                table: "persona");

            migrationBuilder.DropIndex(
                name: "ix_persona_entidad_federativa_id",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "correo_electronico",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "entidad_federativa_id",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "telefono_particular",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "tiempo_residencia",
                table: "persona");

            migrationBuilder.RenameColumn(
                name: "seudonimo",
                table: "persona",
                newName: "apodo");

            migrationBuilder.AlterColumn<int>(
                name: "genero_id",
                table: "persona",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(976), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(985), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(986), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(987), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(988), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(990), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(991), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(992), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(993), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(995), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(996), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(997), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(998), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(999), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1001), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1002), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1003), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1004), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1006), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1007), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1008), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1009), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1010), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1011), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1012), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1013), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1015), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1016), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1017), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1018), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1019), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1020), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1021), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1023), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1024), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1025), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1027), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1028), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1029), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1030), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1031), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1032), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1033), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1035), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1036), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1037), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1038), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1039), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1040), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1041), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1042), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1044), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1045), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1046), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1047), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1048), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1049), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1050), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1051), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1053), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1054), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1055), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1056), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1057), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1058), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1111), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1113), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1114), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1115), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1116), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1117), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1119), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1120), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1121), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1122), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1123), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1124), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1125), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1127), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1128), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1129), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1130), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1131), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1132), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1133), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1134), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1136), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1137), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1138), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1139), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1140), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1141), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1142), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1144), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1145), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1146), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1147), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1148), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1149), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1150), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1151), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1153), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1154), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1155), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1156), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1157), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1158), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1159), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9348), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9356), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9358), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9359), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9360), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9362), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9363), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9365), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9366), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9369), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9371), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9372), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9374), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9375), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9376), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9377), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9378), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9379), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9381), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9382), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9384), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9385), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9386), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9387), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9388), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9389), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9391), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9392), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9393), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "apodo", "fecha_creacion", "fecha_modificacion", "genero_id" },
                values: new object[] { null, new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9450), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9451), null });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "apodo", "fecha_creacion", "fecha_modificacion", "genero_id" },
                values: new object[] { null, new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9684), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9684), null });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(7869), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(7874) });

            migrationBuilder.AddForeignKey(
                name: "fk_persona_genero_genero_id",
                table: "persona",
                column: "genero_id",
                principalTable: "genero",
                principalColumn: "id");
        }
    }
}
