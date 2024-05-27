using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TempNullableEntidadFedPersona : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "fk_persona_entidad_federativa_entidad_federativa_id",
            //    table: "persona");

            migrationBuilder.AlterColumn<string>(
                name: "telefono_particular",
                table: "persona",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "entidad_federativa_id",
                table: "persona",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "correo_electronico",
                table: "persona",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9459), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9469), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9470), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9472), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9473), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9475), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9476), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9477), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9478), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9480), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9481), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9482), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9484), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9485), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9486), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9487), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9488), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9491), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9492), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9493), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9494), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9496), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9497), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9498), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9499), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9500), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9502), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9503), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9504), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9505), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9507), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9508), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9509), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9511), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9512), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9514), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9515), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9516), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9561), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9562), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9564), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9565), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9566), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9567), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9568), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9571), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9572), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9573), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9574), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9576), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9577), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9578), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9579), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9582), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9583), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9584), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9585), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9587), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9588), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9589), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9592), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9593), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9596), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9597), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9598), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9600), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9601), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9602), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9604), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9605), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9606), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9607), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9609), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9610), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9611), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9612), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9614), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9615), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9616), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9617), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9619), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9621), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9622), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9624), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9625), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9626), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9627), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9628), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9631), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9632), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9633), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9635), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9636), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9637), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9638), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9639), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9641), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9642), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9643), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9644), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9645), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9646), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9648), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7910), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7916), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7917), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7918), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7919), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7921), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7922), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7923), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7924), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7925), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7927), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7928), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7929), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7930), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7931), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7932), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7933), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7935), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7936), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7937), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7938), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7939), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7940), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7941), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7942), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7943), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7944), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7945), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7946), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7947), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7948), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7950), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7998), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8236), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(6239), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(6244) });

            //migrationBuilder.AddForeignKey(
            //    name: "fk_persona_entidad_federativa_entidad_federativa_id",
            //    table: "persona",
            //    column: "entidad_federativa_id",
            //    principalTable: "entidad_federativa",
            //    principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_persona_entidad_federativa_entidad_federativa_id",
                table: "persona");

            migrationBuilder.AlterColumn<string>(
                name: "telefono_particular",
                table: "persona",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "entidad_federativa_id",
                table: "persona",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "correo_electronico",
                table: "persona",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3861), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4124), new DateTime(2023, 8, 12, 0, 32, 4, 839, DateTimeKind.Utc).AddTicks(4124) });

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

            migrationBuilder.AddForeignKey(
                name: "fk_persona_entidad_federativa_entidad_federativa_id",
                table: "persona",
                column: "entidad_federativa_id",
                principalTable: "entidad_federativa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
