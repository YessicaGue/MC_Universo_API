using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaPerfilCatalogoRedesSocialesAgregada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "perfil_catalogo_redes_sociales",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    catalogo_redes_sociales_id = table.Column<int>(type: "integer", nullable: false),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_catalogo_redes_sociales", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_catalogo_redes_sociales_catalogo_redes_sociales_cata",
                        column: x => x.catalogo_redes_sociales_id,
                        principalTable: "catalogo_redes_sociales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_catalogo_redes_sociales_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1080), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1086), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1087), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1088), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1089), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1096), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1097), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1098), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1099), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1101), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1121), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1122), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1123), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1124), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1125), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1126), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1127), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1129), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1130), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1131), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1132), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1133), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1134), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1135), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1136), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1137), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1138), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1139), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1140), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1141), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1142), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1143), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1184), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1632), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 59, DateTimeKind.Utc).AddTicks(9568), new DateTime(2023, 6, 12, 2, 6, 23, 59, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.CreateIndex(
                name: "ix_perfil_catalogo_redes_sociales_catalogo_redes_sociales_id",
                table: "perfil_catalogo_redes_sociales",
                column: "catalogo_redes_sociales_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_catalogo_redes_sociales_perfil_id",
                table: "perfil_catalogo_redes_sociales",
                column: "perfil_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "perfil_catalogo_redes_sociales");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7548), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7554), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7556), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7557), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7558), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7560), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7562), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7563), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7564), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7565), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7566), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7568), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7569), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7570), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7571), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7572), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7573), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7574), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7575), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7576), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7577), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7578), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7579), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7580), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7581), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7582), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7584), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7585), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7586), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7587), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7588), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7629), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7837), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(6284), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(6288) });
        }
    }
}
