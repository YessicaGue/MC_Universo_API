using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class CreacionyPoblaciondeTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "perfil_grupal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    guid = table.Column<Guid>(type: "uuid", nullable: false),
                    alias = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    url = table.Column<string>(type: "text", nullable: false),
                    es_publico = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_grupal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "perfil_sigue_perfil_grupal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_grupal_seguido_id = table.Column<int>(type: "integer", nullable: false),
                    perfil_seguidor_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_sigue_perfil_grupal", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_sigue_perfil_grupal_perfil_grupal_perfil_grupal_segu",
                        column: x => x.perfil_grupal_seguido_id,
                        principalTable: "perfil_grupal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_sigue_perfil_grupal_perfil_perfil_seguidor_id",
                        column: x => x.perfil_seguidor_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuario_perfil_grupal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario_id = table.Column<int>(type: "integer", nullable: false),
                    perfil_grupal_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_usuario_perfil_grupal", x => x.id);
                    table.ForeignKey(
                        name: "fk_usuario_perfil_grupal_perfil_grupal_perfil_grupal_id",
                        column: x => x.perfil_grupal_id,
                        principalTable: "perfil_grupal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6721), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6728), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6731), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6733), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6736), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6740), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6742), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6745), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6747), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6752), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6754), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6781), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6783), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6786), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6788), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6790), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6793), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6816), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6819), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6821), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6823), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6825), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6828), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6830), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6833), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6835), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6838), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6840), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6842), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6844), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6847), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6849), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6934), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7367), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(4226), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(4229) });

            migrationBuilder.CreateIndex(
                name: "ix_perfil_sigue_perfil_grupal_perfil_grupal_seguido_id",
                table: "perfil_sigue_perfil_grupal",
                column: "perfil_grupal_seguido_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_sigue_perfil_grupal_perfil_seguidor_id",
                table: "perfil_sigue_perfil_grupal",
                column: "perfil_seguidor_id");

            migrationBuilder.CreateIndex(
                name: "ix_usuario_perfil_grupal_perfil_grupal_id",
                table: "usuario_perfil_grupal",
                column: "perfil_grupal_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "perfil_sigue_perfil_grupal");

            migrationBuilder.DropTable(
                name: "usuario_perfil_grupal");

            migrationBuilder.DropTable(
                name: "perfil_grupal");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1570), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1576), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1577), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1578), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1579), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1582), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1583), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1584), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1585), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1587), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1588), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1589), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1590), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1591), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1592), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1593), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1594), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1595), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1596), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1597), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1598), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1599), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1600), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1601), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1602), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1603), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1604), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1605), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1606), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1607), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1608), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1609), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1648), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1855), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(171), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(176) });
        }
    }
}
