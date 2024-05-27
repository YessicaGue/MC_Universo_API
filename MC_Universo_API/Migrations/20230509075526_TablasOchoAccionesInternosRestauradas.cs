using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasOchoAccionesInternosRestauradas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "registro_ocho_acciones_usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_registro_ocho_acciones_usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "registro_ocho_acciones_usuario_catalogo_ocho_acciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    registro_ocho_acciones_usuario_id = table.Column<int>(type: "integer", nullable: false),
                    catalogo_ocho_acciones_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_registro_ocho_acciones_usuario_catalogo_ocho_acciones", x => x.id);
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_usuario_catalogo_ocho_acciones_catal",
                        column: x => x.catalogo_ocho_acciones_id,
                        principalTable: "catalogo_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_usuario_catalogo_ocho_acciones_regis",
                        column: x => x.registro_ocho_acciones_usuario_id,
                        principalTable: "registro_ocho_acciones_usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "respuestas_ocho_acciones_registro_ocho_acciones_usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    registro_ocho_acciones_usuario_id = table.Column<int>(type: "integer", nullable: false),
                    pregunta_id = table.Column<int>(type: "integer", nullable: false),
                    respuesta = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_respuestas_ocho_acciones_registro_ocho_acciones_usuario", x => x.id);
                    table.ForeignKey(
                        name: "fk_respuestas_ocho_acciones_registro_ocho_acciones_usuario_cat",
                        column: x => x.pregunta_id,
                        principalTable: "catalogo_preguntas_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_respuestas_ocho_acciones_registro_ocho_acciones_usuario_reg",
                        column: x => x.registro_ocho_acciones_usuario_id,
                        principalTable: "registro_ocho_acciones_usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6341), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6346), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6348), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6349), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6350), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6352), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6353), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6354), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6355), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6356), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6357), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6358), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6359), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6360), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6361), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6363), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6364), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6365), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6366), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6367), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6368), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6369), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6370), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6371), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6372), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6373), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6374), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6375), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6376), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6377), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6378), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6379), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6416), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6649), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(4894), new DateTime(2023, 5, 9, 7, 55, 25, 945, DateTimeKind.Utc).AddTicks(4899) });

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_usuario_catalogo_ocho_acciones_catal",
                table: "registro_ocho_acciones_usuario_catalogo_ocho_acciones",
                column: "catalogo_ocho_acciones_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_usuario_catalogo_ocho_acciones_regis",
                table: "registro_ocho_acciones_usuario_catalogo_ocho_acciones",
                column: "registro_ocho_acciones_usuario_id");

            migrationBuilder.CreateIndex(
                name: "ix_respuestas_ocho_acciones_registro_ocho_acciones_usuario_pre",
                table: "respuestas_ocho_acciones_registro_ocho_acciones_usuario",
                column: "pregunta_id");

            migrationBuilder.CreateIndex(
                name: "ix_respuestas_ocho_acciones_registro_ocho_acciones_usuario_reg",
                table: "respuestas_ocho_acciones_registro_ocho_acciones_usuario",
                column: "registro_ocho_acciones_usuario_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "registro_ocho_acciones_usuario_catalogo_ocho_acciones");

            migrationBuilder.DropTable(
                name: "respuestas_ocho_acciones_registro_ocho_acciones_usuario");

            migrationBuilder.DropTable(
                name: "registro_ocho_acciones_usuario");

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
    }
}
