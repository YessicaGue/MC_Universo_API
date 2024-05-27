using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AgregadoColumnaUrlVideoPerfilGrupalMigracionCorregida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "nombre" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5536), "Instagram personal 1" });

            migrationBuilder.InsertData(
                table: "catalogo_tokens",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 2, true, new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5542), "Instagram personal 2" },
                    { 3, true, new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5543), "Instagram grupal" }
                });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4090), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4096), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4097), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4099), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4100), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4102), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4104), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4105), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4106), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4108), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4110), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4111), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4123), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4124), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4127), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4128), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4130), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4132), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4133), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4177), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4179), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4180), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4182), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4183), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4184), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4185), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4186), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4188), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4189), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4191), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4193), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4262), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4670), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(2007), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(2011) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "nombre" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5562), "Instagram" });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3744), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3761), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3764), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3767), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3770), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3773), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3775), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3777), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3780), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3784), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3786), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3809), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3812), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3814), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3816), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3818), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3820), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3824), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3826), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3828), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3831), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3833), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3835), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3837), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3840), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3842), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3844), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3846), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3849), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3851), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3853), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3855), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3936), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4374), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(1288), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(1293) });
        }
    }
}
