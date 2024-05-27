using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasSeguidoresCompletadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "activo",
                table: "perfil_sigue_perfil_grupal",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_actualizacion",
                table: "perfil_sigue_perfil_grupal",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "activo",
                table: "perfil_sigue_perfil",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_actualizacion",
                table: "perfil_sigue_perfil",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "perfil_grupal_sigue_perfil",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_seguido_id = table.Column<int>(type: "integer", nullable: false),
                    perfil_grupal_seguidor_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_grupal_sigue_perfil", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_grupal_sigue_perfil_perfil_grupal_perfil_grupal_segu",
                        column: x => x.perfil_grupal_seguidor_id,
                        principalTable: "perfil_grupal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_grupal_sigue_perfil_perfil_perfil_seguido_id",
                        column: x => x.perfil_seguido_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "perfil_grupal_sigue_perfil_grupal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_grupal_seguido_id = table.Column<int>(type: "integer", nullable: false),
                    perfil_grupal_seguidor_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_grupal_sigue_perfil_grupal", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_grupal_sigue_perfil_grupal_perfil_grupal_perfil_grup",
                        column: x => x.perfil_grupal_seguido_id,
                        principalTable: "perfil_grupal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_grupal_sigue_perfil_grupal_perfil_grupal_perfil_grup1",
                        column: x => x.perfil_grupal_seguidor_id,
                        principalTable: "perfil_grupal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 817, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 817, DateTimeKind.Utc).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9466), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9472), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9474), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9476), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9477), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9479), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9481), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9482), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9483), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9485), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9486), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9488), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9490), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9491), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9492), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9494), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9495), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9497), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9498), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9500), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9501), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9502), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9504), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9505), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9506), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9507), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9509), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9511), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9512), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9514), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9515), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9517), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9518), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9520), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9521), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9522), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9524), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9525), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9526), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9527), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9529), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9530), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9531), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9533), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9534), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9535), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9536), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9538), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9539), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9540), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9542), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9543), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9544), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9545), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9547), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9548), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9549), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9551), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9552), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9553), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9554), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9556), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9557), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9558), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9589), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9592), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9593), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9594), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9596), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9597), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9598), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9600), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9601), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9602), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9604), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9605), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9606), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9607), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9608), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9610), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9611), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9613), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9614), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9615), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9616), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9618), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9619), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9622), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9623), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9624), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9625), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9627), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9628), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9629), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9631), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9632), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9633), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9635), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9636), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9637), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9639), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9641), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9643), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9644), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9645), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9647), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9648), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9649), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9651), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9652), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9654), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9655), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9656), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8342), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8348), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8349), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8350), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8351), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8353), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8354), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8355), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8356), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8357), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8358), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8359), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8360), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8361), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8362), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8363), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8364), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8366), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8367), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8368), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8369), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8370), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8371), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8372), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8373), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8374), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8375), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8376), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8377), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8378), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8379), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8380), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8423), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8619), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(7122), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(7125) });

            migrationBuilder.CreateIndex(
                name: "ix_perfil_grupal_sigue_perfil_perfil_grupal_seguidor_id",
                table: "perfil_grupal_sigue_perfil",
                column: "perfil_grupal_seguidor_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_grupal_sigue_perfil_perfil_seguido_id",
                table: "perfil_grupal_sigue_perfil",
                column: "perfil_seguido_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_grupal_sigue_perfil_grupal_perfil_grupal_seguido_id",
                table: "perfil_grupal_sigue_perfil_grupal",
                column: "perfil_grupal_seguido_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_grupal_sigue_perfil_grupal_perfil_grupal_seguidor_id",
                table: "perfil_grupal_sigue_perfil_grupal",
                column: "perfil_grupal_seguidor_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "perfil_grupal_sigue_perfil");

            migrationBuilder.DropTable(
                name: "perfil_grupal_sigue_perfil_grupal");

            migrationBuilder.DropColumn(
                name: "activo",
                table: "perfil_sigue_perfil_grupal");

            migrationBuilder.DropColumn(
                name: "fecha_actualizacion",
                table: "perfil_sigue_perfil_grupal");

            migrationBuilder.DropColumn(
                name: "activo",
                table: "perfil_sigue_perfil");

            migrationBuilder.DropColumn(
                name: "fecha_actualizacion",
                table: "perfil_sigue_perfil");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5673), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5727), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5729), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5731), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5732), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5735), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5736), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5738), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5739), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5741), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5742), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5744), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5745), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5746), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5747), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5749), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5750), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5752), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5754), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5755), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5757), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5758), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5760), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5761), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5762), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5763), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5764), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5766), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5767), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5768), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5770), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5771), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5772), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5774), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5776), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5777), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5779), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5780), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5781), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5782), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5784), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5785), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5787), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5788), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5789), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5791), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5792), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5793), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5795), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5796), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5797), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5799), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5800), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5801), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5802), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5804), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5805), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5807), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5808), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5809), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5811), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5812), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5814), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5815), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5816), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5863), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5864), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5866), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5867), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5869), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5870), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5872), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5873), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5874), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5876), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5877), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5878), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5880), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5881), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5882), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5883), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5885), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5886), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5888), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5889), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5890), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5891), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5893), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5894), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5895), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5897), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5898), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5899), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5900), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5902), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5903), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5905), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5906), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5907), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5909), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5910), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5911), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5913), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5914), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5915), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5916), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5918), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5919), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5921), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5922), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5923), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5925), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5926), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5927), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5929), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5930), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5931), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4591), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4597), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4598), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4599), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4600), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4628), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4629), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4630), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4631), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4633), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4634), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4635), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4636), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4637), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4638), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4639), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4640), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4642), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4643), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4644), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4645), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4646), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4647), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4648), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4649), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4650), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4651), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4652), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4653), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4654), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4655), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4656), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4693), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4892), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(3433), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(3435) });
        }
    }
}
