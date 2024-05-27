using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasOchoAccionesInternosEliminadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "respuestas_ocho_acciones_usuario");

            migrationBuilder.DropTable(
                name: "usuario_catalogo_ocho_acciones");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(481), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(487), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(489), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(490), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(492), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(494), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(496), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(497), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(498), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(500), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(501), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(503), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(504), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(505), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(506), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(507), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(508), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(511), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(512), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(513), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(514), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(515), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(517), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(518), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(519), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(520), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(521), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(523), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(524), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(525), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(526), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(528), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(572), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(814), new DateTime(2023, 5, 9, 7, 35, 38, 952, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 35, 38, 951, DateTimeKind.Utc).AddTicks(8964), new DateTime(2023, 5, 9, 7, 35, 38, 951, DateTimeKind.Utc).AddTicks(8967) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "usuario_catalogo_ocho_acciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    catalogo_ocho_acciones_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_usuario_catalogo_ocho_acciones", x => x.id);
                    table.ForeignKey(
                        name: "fk_usuario_catalogo_ocho_acciones_catalogo_ocho_acciones_catal",
                        column: x => x.catalogo_ocho_acciones_id,
                        principalTable: "catalogo_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "respuestas_ocho_acciones_usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pregunta_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_catalogo_ocho_acciones_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    respuesta = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_respuestas_ocho_acciones_usuario", x => x.id);
                    table.ForeignKey(
                        name: "fk_respuestas_ocho_acciones_usuario_catalogo_preguntas_ocho_ac",
                        column: x => x.pregunta_id,
                        principalTable: "catalogo_preguntas_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_respuestas_ocho_acciones_usuario_usuario_catalogo_ocho_acci",
                        column: x => x.usuario_catalogo_ocho_acciones_id,
                        principalTable: "usuario_catalogo_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5963), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5970), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5971), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5972), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5973), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5975), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5976), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5977), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5978), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5980), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5981), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5982), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5983), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5984), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5985), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5986), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5987), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5988), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5989), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5990), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5991), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5992), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5993), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5994), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5995), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5996), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5997), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5998), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5999), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6000), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6001), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6002), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6042), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6249), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(4682), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.CreateIndex(
                name: "ix_respuestas_ocho_acciones_usuario_pregunta_id",
                table: "respuestas_ocho_acciones_usuario",
                column: "pregunta_id");

            migrationBuilder.CreateIndex(
                name: "ix_respuestas_ocho_acciones_usuario_usuario_catalogo_ocho_acci",
                table: "respuestas_ocho_acciones_usuario",
                column: "usuario_catalogo_ocho_acciones_id");

            migrationBuilder.CreateIndex(
                name: "ix_usuario_catalogo_ocho_acciones_catalogo_ocho_acciones_id",
                table: "usuario_catalogo_ocho_acciones",
                column: "catalogo_ocho_acciones_id");
        }
    }
}
