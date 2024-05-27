using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasTokensAgregadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "token",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    stringified_token = table.Column<string>(type: "text", nullable: false),
                    expirable = table.Column<bool>(type: "boolean", nullable: false),
                    segundos_expira = table.Column<int>(type: "integer", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_token", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "perfil_token",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    token_id = table.Column<int>(type: "integer", nullable: false),
                    response = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_token", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_token_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_token_token_token_id",
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
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7404), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7410), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7411), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7412), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7413), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7415), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7416), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7417), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7419), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7420), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7421), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7422), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7423), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7424), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7425), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7426), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7427), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7429), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7430), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7431), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7432), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7433), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7434), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7435), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7436), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7437), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7438), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7439), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7440), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7441), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7442), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7443), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7477), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7704), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(6085), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.CreateIndex(
                name: "ix_perfil_token_perfil_id",
                table: "perfil_token",
                column: "perfil_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_token_token_id",
                table: "perfil_token",
                column: "token_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "perfil_token");

            migrationBuilder.DropTable(
                name: "token");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3893), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3899), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3901), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3903), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3904), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3907), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3908), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3909), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3910), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3912), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3914), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3915), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3917), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3918), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3919), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3920), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3922), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3924), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3926), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3927), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3928), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3929), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3931), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3932), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3933), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3934), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3936), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3937), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3938), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3939), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3941), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3942), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3996), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4236), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(2133), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(2142) });
        }
    }
}
