using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaArchivoColumnaTipoAgregada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "tipo",
                table: "archivo",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8576), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8584), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8586), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8587), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8588), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8590), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8591), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8592), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8593), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8594), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8595), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8596), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8597), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8598), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8599), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8600), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8601), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8603), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8604), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8605), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8606), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8607), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8608), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8609), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8610), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8611), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8612), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8613), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8614), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8615), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8616), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8617), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8660), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8898), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(7086), new DateTime(2023, 7, 21, 7, 47, 31, 660, DateTimeKind.Utc).AddTicks(7091) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tipo",
                table: "archivo");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(799), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(806), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(807), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(809), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(810), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(813), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(814), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(815), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(817), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(819), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(821), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(822), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(830), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(831), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(832), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(834), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(835), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(838), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(839), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(840), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(841), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(843), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(845), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(846), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(847), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(848), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(849), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(850), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(852), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(855), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(856), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(858), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(925), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1307), new DateTime(2023, 7, 19, 21, 11, 26, 718, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 21, 11, 26, 717, DateTimeKind.Utc).AddTicks(8468), new DateTime(2023, 7, 19, 21, 11, 26, 717, DateTimeKind.Utc).AddTicks(8473) });
        }
    }
}
