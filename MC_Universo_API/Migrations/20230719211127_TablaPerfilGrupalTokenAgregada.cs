using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaPerfilGrupalTokenAgregada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "perfil_grupal_token",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_grupal_id = table.Column<int>(type: "integer", nullable: false),
                    token_id = table.Column<int>(type: "integer", nullable: false),
                    response = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_grupal_token", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_grupal_token_perfil_grupal_perfil_grupal_id",
                        column: x => x.perfil_grupal_id,
                        principalTable: "perfil_grupal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_grupal_token_token_token_id",
                        column: x => x.token_id,
                        principalTable: "token",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "ix_perfil_grupal_token_perfil_grupal_id",
                table: "perfil_grupal_token",
                column: "perfil_grupal_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_grupal_token_token_id",
                table: "perfil_grupal_token",
                column: "token_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "perfil_grupal_token");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6011), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6022), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6023), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6024), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6026), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6028), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6029), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6030), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6031), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6033), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6035), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6036), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6037), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6039), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6040), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6041), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6042), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6044), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6045), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6047), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6048), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6049), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6050), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6052), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6053), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6054), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6055), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6056), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6057), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6058), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6060), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6061), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6108), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6343), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(4308), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(4312) });
        }
    }
}
