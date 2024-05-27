using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaRegistroOchoAccionesCorregidaNullEscolaridadMotivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_registro_ocho_acciones_escolaridad_escolaridad_id",
                table: "registro_ocho_acciones");

            migrationBuilder.DropForeignKey(
                name: "fk_registro_ocho_acciones_motivo_motivo_id",
                table: "registro_ocho_acciones");

            migrationBuilder.AlterColumn<int>(
                name: "motivo_id",
                table: "registro_ocho_acciones",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "escolaridad_id",
                table: "registro_ocho_acciones",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7578), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7585), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7586), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7587), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7588), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7589), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7590), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7616), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7617), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7618), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7619), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7620), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7621), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7622), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7623), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7625), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7626), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7627), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7628), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7629), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7630), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7631), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7632), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7634), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7635), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7636), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7637), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7638), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7639), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7640), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7641), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7680), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7903), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(6247), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(6251) });

            migrationBuilder.AddForeignKey(
                name: "fk_registro_ocho_acciones_escolaridad_escolaridad_id",
                table: "registro_ocho_acciones",
                column: "escolaridad_id",
                principalTable: "escolaridad",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_registro_ocho_acciones_motivo_motivo_id",
                table: "registro_ocho_acciones",
                column: "motivo_id",
                principalTable: "motivo",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_registro_ocho_acciones_escolaridad_escolaridad_id",
                table: "registro_ocho_acciones");

            migrationBuilder.DropForeignKey(
                name: "fk_registro_ocho_acciones_motivo_motivo_id",
                table: "registro_ocho_acciones");

            migrationBuilder.AlterColumn<int>(
                name: "motivo_id",
                table: "registro_ocho_acciones",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "escolaridad_id",
                table: "registro_ocho_acciones",
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
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3610), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3616), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3617), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3618), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3619), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3620), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3622), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3623), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3624), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3626), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3627), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3628), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3629), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3630), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3631), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3632), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3633), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3634), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3635), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3636), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3637), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3638), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3639), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3640), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3641), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3642), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3643), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3644), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3645), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3646), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3647), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3648), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3677), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3890), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(2440), new DateTime(2023, 5, 16, 15, 38, 15, 601, DateTimeKind.Utc).AddTicks(2444) });

            migrationBuilder.AddForeignKey(
                name: "fk_registro_ocho_acciones_escolaridad_escolaridad_id",
                table: "registro_ocho_acciones",
                column: "escolaridad_id",
                principalTable: "escolaridad",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_registro_ocho_acciones_motivo_motivo_id",
                table: "registro_ocho_acciones",
                column: "motivo_id",
                principalTable: "motivo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
