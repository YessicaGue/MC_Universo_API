using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaEscuchaCorregida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "apellido_materno",
                table: "escucha",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "apellido_paterno",
                table: "escucha",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "escucha",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "entidad_federativa_id",
                table: "escucha",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "escucha",
                type: "text",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "ix_escucha_entidad_federativa_id",
                table: "escucha",
                column: "entidad_federativa_id");

            migrationBuilder.AddForeignKey(
                name: "fk_escucha_entidad_federativa_entidad_federativa_id",
                table: "escucha",
                column: "entidad_federativa_id",
                principalTable: "entidad_federativa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_escucha_entidad_federativa_entidad_federativa_id",
                table: "escucha");

            migrationBuilder.DropIndex(
                name: "ix_escucha_entidad_federativa_id",
                table: "escucha");

            migrationBuilder.DropColumn(
                name: "apellido_materno",
                table: "escucha");

            migrationBuilder.DropColumn(
                name: "apellido_paterno",
                table: "escucha");

            migrationBuilder.DropColumn(
                name: "correo",
                table: "escucha");

            migrationBuilder.DropColumn(
                name: "entidad_federativa_id",
                table: "escucha");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "escucha");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6341), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6346), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6348), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6349), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6350), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6352), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6353), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6354), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6355), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6356), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6357), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6358), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6359), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6360), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6361), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6363), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6364), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6365), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6366), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6367), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6368), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6369), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6370), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6371), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6372), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6373), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6374), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6375), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6376), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6377), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6378), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6379), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6416), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6649), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(4894), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(4899) });
        }
    }
}
