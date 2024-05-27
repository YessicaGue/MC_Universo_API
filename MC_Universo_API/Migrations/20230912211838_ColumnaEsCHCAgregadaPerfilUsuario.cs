using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class ColumnaEsCHCAgregadaPerfilUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "es_chc",
                table: "perfil_usuario",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                comment: "Esta columna indica si hizo el registro del perfil desde la liga para redireccionar directamente a CHC");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "es_chc",
                table: "perfil_usuario");

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
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3753));

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
                column: "fecha_alta",
                value: new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3241), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3247), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3248), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3250), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3252), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3253), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3255), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3256), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3257), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3259), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3261), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3262), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3263), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3265), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3266), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3267), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3269), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3270), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3272), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3273), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3274), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3276), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3277), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3279), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3280), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3281), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3282), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3283), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3284), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3286), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3287), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3289), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3290), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3292), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3293), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3294), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3296), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3297), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3298), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3299), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3301), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3302), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3303), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3305), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3306), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3307), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3309), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3310), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3311), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3313), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3314), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3340), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3342), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3343), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3344), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3346), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3347), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3348), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3350), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3351), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3352), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3354), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3355), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3356), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3358), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3359), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3361), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3362), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3363), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3365), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3366), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3368), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3369), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3370), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3371), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3373), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3374), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3375), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3376), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3378), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3379), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3380), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3382), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3383), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3384), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3386), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3387), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3388), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3390), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3391), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3392), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3393), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3395), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3396), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3397), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3399), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3400), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3401), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3403), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3404), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3405), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3407), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3408), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3409), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3410), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3411), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3413), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3414), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3416), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3417), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3418), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3419), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3421), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3422), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3423), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3425), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3426), new DateTime(2023, 9, 12, 18, 5, 35, 317, DateTimeKind.Utc).AddTicks(3426) });

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
    }
}
