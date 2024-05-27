using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionPublicacionPerfilesGrupales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 962, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8813), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8820), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8823), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8825), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8827), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8832), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8834), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8837), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8839), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8844), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8846), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8868), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8870), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8873), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8875), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8877), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8879), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8883), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8885), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8888), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8890), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8892), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8894), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8896), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8898), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8901), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8903), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8905), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8907), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8909), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8911), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8914), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8994), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(9423), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(6196), new DateTime(2023, 6, 29, 21, 14, 33, 961, DateTimeKind.Utc).AddTicks(6199) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(788), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(795), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(798), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(800), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(802), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(807), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(809), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(811), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(813), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(817), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(819), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(843), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(846), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(848), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(851), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(853), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(855), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(859), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(861), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(864), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(866), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(868), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(870), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(873), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(875), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(877), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(879), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(882), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(884), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(886), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(888), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(890), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(971), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1397), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 300, DateTimeKind.Utc).AddTicks(8238), new DateTime(2023, 6, 29, 21, 4, 29, 300, DateTimeKind.Utc).AddTicks(8241) });
        }
    }
}
