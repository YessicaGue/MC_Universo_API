using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedPerfilesGrupales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4807), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4811), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4812), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4813), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4814), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4816), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4817), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4818), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4819), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4822), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4823), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4824), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4825), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4826), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4827), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4828), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4829), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4830), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4832), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4832), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4833), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4835), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4836), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4837), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4837), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4838), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4840), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4841), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4842), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4843), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4844), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4845), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4876), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5078), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(3677), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(3680) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5920), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5926), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5927), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5928), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5930), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5931), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5932), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5933), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5935), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5937), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5938), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5939), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5940), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5941), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5942), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5943), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5944), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5946), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5947), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5948), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5949), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5950), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5951), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5952), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5953), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5954), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5955), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5956), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5957), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5958), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5959), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5960), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5995), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6206), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(4618), new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(4622) });
        }
    }
}
