using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedPrefilesGrupales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "perfil_grupal",
                columns: new[] { "id", "activo", "alias", "fecha_creacion", "foto", "frase", "guid", "url", "es_publico" },
                values: new object[,]
                {
                    { 1, true, "Jóvenes en movimiento", new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6860), "group_profile_pictures/aJHsgP8cftCAYEpWUDToyrgT1ee3xoANpq8XaUU2.jpg", "La uniòn hace cambios", new Guid("5d3e0abe-ef5a-4848-90ba-5adfaba23002"), "jovenes-en-movimiento", true },
                    { 2, true, "Mujeres en Movimiento", new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6866), "group_profile_pictures/aJHsgP8cftCAYEpWUDToyrgT1ee3xoANpq8XaUU2.jpg", "Por una participación afectiva", new Guid("65fb3612-7866-44d1-9126-efc72ca2dda7"), "mujeres-en-movimiento", true },
                    { 3, true, "Fundación México con Valores", new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6905), "group_profile_pictures/aJHsgP8cftCAYEpWUDToyrgT1ee3xoANpq8XaUU2.jpg", "Ciudadanos comprometidos", new Guid("4e298068-e6f0-439b-ad45-888342daa9d4"), "fundacion-mexico-valores", true },
                    { 4, true, "Mercadito Naranja", new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6909), "group_profile_pictures/aJHsgP8cftCAYEpWUDToyrgT1ee3xoANpq8XaUU2.jpg", "Mercadito Naranja", new Guid("e021dc57-3195-4a74-9f58-6297cb91fa18"), "mercadito-naranja", true },
                    { 5, true, "LabMC", new DateTime(2023, 7, 5, 18, 35, 6, 561, DateTimeKind.Utc).AddTicks(6913), "group_profile_pictures/aJHsgP8cftCAYEpWUDToyrgT1ee3xoANpq8XaUU2.jpg", "LabMC", new Guid("05474085-5a72-4d8e-869e-8be96adafaf8"), "lab-mc", true }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7983), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7992), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7993), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7994), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7995), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7998), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7999), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8000), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8001), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8003), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8005), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8006), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8007), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8008), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8009), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8012), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8014), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8015), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8016), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8017), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8018), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8020), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8021), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8022), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8023), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8025), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8026), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8027), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8029), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8030), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8031), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8081), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8336), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(6234), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(6237) });
        }
    }
}
