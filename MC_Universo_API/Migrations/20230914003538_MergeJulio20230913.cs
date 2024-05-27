using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeJulio20230913 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "es_chc",
                table: "perfil_usuario",
                type: "boolean",
                nullable: true,
                comment: "Esta columna indica si hizo el registro del perfil desde la liga para redireccionar directamente a CHC",
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldComment: "Esta columna indica si hizo el registro del perfil desde la liga para redireccionar directamente a CHC");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.InsertData(
                table: "catalogo_documentos_eligibilidad_chc",
                columns: new[] { "id", "activo", "descripcion", "fecha_creacion", "nombre" },
                values: new object[] { 1, true, "Carta Compromiso", new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7245), "Carta Compromiso" });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6601), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6608), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6609), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6611), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6612), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6614), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6616), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6617), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6618), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6620), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6621), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6622), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6624), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6625), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6626), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6627), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6629), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6630), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6632), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6633), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6635), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6636), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6637), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6638), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6640), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6641), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6642), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6643), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6645), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6646), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6647), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6649), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6650), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6652), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6653), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6655), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6656), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6657), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6659), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6660), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6661), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6662), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6664), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6665), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6666), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6668), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6669), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6670), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6672), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6673), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6674), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6675), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6677), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6678), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6679), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6681), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6682), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6683), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6685), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6686), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6687), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6688), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6690), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6691), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6692), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6742), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6743), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6744), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6746), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6747), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6748), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6750), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6751), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6752), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6754), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6755), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6756), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6758), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6759), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6760), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6761), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6763), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6764), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6766), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6767), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6768), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6769), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6771), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6772), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6773), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6775), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6776), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6777), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6778), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6780), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6781), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6783), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6784), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6785), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6786), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6788), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6789), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6790), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6792), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6793), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6794), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6795), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6797), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6798), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6799), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6801), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6802), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6803), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6805), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6806), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6807), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6809), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5432), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5438), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5439), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5440), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5441), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5443), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5444), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5445), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5446), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5447), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5448), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5449), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5453), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5454), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5455), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5456), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5457), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5459), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5460), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5461), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5462), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5463), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5464), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5465), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5466), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5467), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5468), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5469), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5470), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5471), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5472), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5473), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5516), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5724), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(4262), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(4266) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.AlterColumn<bool>(
                name: "es_chc",
                table: "perfil_usuario",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                comment: "Esta columna indica si hizo el registro del perfil desde la liga para redireccionar directamente a CHC",
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true,
                oldComment: "Esta columna indica si hizo el registro del perfil desde la liga para redireccionar directamente a CHC");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(882), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(889), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(891), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(893), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(895), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(897), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(898), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(900), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(901), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(903), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(904), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(905), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(907), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(908), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(909), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(910), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(942), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(944), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(946), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(947), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(948), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(950), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(951), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(953), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(954), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(955), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(956), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(957), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(958), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(960), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(961), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(963), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(964), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(966), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(967), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(968), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(970), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(971), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(972), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(974), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(975), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(977), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(978), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(979), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(981), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(982), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(983), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(985), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(986), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(987), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(989), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(990), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(991), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(992), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(994), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(995), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(996), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(998), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(999), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1000), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1001), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1003), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1004), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1005), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1006), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1008), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1009), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1011), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1012), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1013), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1015), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1016), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1017), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1018), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1020), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1021), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1022), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1024), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1025), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1026), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1027), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1054), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1056), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1057), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1058), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1060), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1061), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1062), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1064), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1065), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1066), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1067), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1068), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1070), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1071), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1073), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1074), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1075), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1077), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1078), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1079), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1081), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1082), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1084), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1085), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1086), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1087), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1089), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1090), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1091), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1093), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1094), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1095), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1097), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1098), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1099), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1100), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9671), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9682), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9683), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9684), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9685), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9687), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9688), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9689), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9690), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9691), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9692), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9693), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9694), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9695), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9696), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9697), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9698), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9700), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9701), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9702), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9703), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9704), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9705), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9706), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9707), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9708), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9735), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9736), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9738), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9739), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9740), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9741), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9789), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(53), new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 21, 18, 37, 733, DateTimeKind.Utc).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(8415), new DateTime(2023, 9, 12, 21, 18, 37, 732, DateTimeKind.Utc).AddTicks(8418) });
        }
    }
}
