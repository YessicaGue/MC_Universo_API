using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class CambiosJulioExtraidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5401), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5407), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5408), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5409), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5410), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5412), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5413), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5414), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5415), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5417), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5418), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5419), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5420), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5425), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5426), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5427), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5428), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5430), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5431), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5432), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5433), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5434), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5435), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5436), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5437), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5438), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5439), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5440), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5441), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5442), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5443), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5444), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5477), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5696), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(4078), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(4082) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3124), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3130), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3131), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3132), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3133), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3135), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3136), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3137), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3138), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3139), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3140), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3141), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3142), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3143), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3144), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3145), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3146), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3148), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3149), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3150), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3151), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3152), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3153), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3154), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3155), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3156), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3157), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3158), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3159), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3160), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3161), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3162), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3201), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3393), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(1915), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(1919) });
        }
    }
}
