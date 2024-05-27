using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaEscuchaCorregidaDefaultNullEntidadFederativa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_escucha_entidad_federativa_entidad_federativa_id",
                table: "escucha");

            migrationBuilder.AlterColumn<int>(
                name: "entidad_federativa_id",
                table: "escucha",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

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
                name: "fk_escucha_entidad_federativa_entidad_federativa_id",
                table: "escucha",
                column: "entidad_federativa_id",
                principalTable: "entidad_federativa",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_escucha_entidad_federativa_entidad_federativa_id",
                table: "escucha");

            migrationBuilder.AlterColumn<int>(
                name: "entidad_federativa_id",
                table: "escucha",
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
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8598), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8605), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8606), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8608), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8609), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8611), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8612), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8614), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8615), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8617), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8618), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8620), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8621), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8622), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8623), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8624), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8626), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8628), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8629), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8630), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8631), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8632), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8633), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8635), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8637), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8638), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8639), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8641), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8642), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8643), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8644), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8645), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8703), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8996), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(6505), new DateTime(2023, 5, 10, 6, 41, 48, 571, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.AddForeignKey(
                name: "fk_escucha_entidad_federativa_entidad_federativa_id",
                table: "escucha",
                column: "entidad_federativa_id",
                principalTable: "entidad_federativa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
