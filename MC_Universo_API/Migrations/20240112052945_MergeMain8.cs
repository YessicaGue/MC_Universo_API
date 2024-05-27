using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeMain8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alias",
                table: "perfil_precandidatura");

            migrationBuilder.AlterTable(
                name: "perfil",
                oldComment: "Debido a que cada perfil puede tener ser visitable por customurl, se establece constraint unique");

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_actualizacion",
                table: "usuario_perfil",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_baja",
                table: "usuario_perfil",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_actualizacion",
                table: "perfil_usuario",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_baja",
                table: "perfil_usuario",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "entidad_federativa_id",
                table: "perfil_precandidatura",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_baja",
                table: "perfil_precandidatura",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "municipio",
                table: "perfil_precandidatura",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telefono",
                table: "perfil_precandidatura",
                type: "character varying(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_actualizacion",
                table: "perfil_catalogo_redes_sociales",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_baja",
                table: "perfil_catalogo_redes_sociales",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_actualizacion",
                table: "perfil",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_baja",
                table: "perfil",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_actualizacion",
                table: "catalogo_redes_sociales",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_baja",
                table: "catalogo_redes_sociales",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "catalogo_puesto_precandidatura",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_puesto_precandidatura", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "perfil_persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_persona", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_persona_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_persona_persona_persona_id",
                        column: x => x.persona_id,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9313), "i08unbxs" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9327), "z06n3o0k" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9330), "uqyxtzcw" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9332), "dvc7kxt5" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9334), "cemug63k" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9337), "ytl1n4yg" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9339), "7rbca7go" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8117), "3gk05eha" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8145), "anfecopg" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8148), "40xso0jv" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8150), "6zn9z7ab" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8184), "1a6ldgy1" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9500), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9508), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9509), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7293), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7307), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7308), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7310), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7312), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7314), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7315), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7317), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7318), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7320), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7321), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7322), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7323), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7325), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7326), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7327), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7329), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7337), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7339), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7340), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7342), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7343), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7344), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7346), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7347), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7348), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7350), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7351), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7352), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7353), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7355), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7356), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7358), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7360), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7361), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7362), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7363), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7365), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7366), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7367), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7368), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7370), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7371), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7372), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7374), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7375), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7376), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7378), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7379), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7380), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7381), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7383), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7384), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7385), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7386), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7388), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7389), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7391), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7392), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7393), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7394), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7396), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7397), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7398), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7400), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7402), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7403), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7404), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7406), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7407), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7408), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7410), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7411), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7412), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7414), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7415), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7416), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7417), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7419), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7420), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7421), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7423), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7424), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7425), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7435), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7436), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7437), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7439), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7440), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7441), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7443), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7444), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7445), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7446), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7448), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7449), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7451), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7452), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7453), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7455), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7456), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7457), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7458), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7460), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7461), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7462), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7464), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7465), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7467), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7468), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7469), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7471), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7472), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7473), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7475), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7476), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7477), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_baja", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6798), null, new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_baja", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6806), null, new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_baja", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6807), null, new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_baja", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6808), null, new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_baja", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6809), null, new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_baja", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6811), null, new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8242), "3uv4l9mh" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8248), "2qlx4y1q" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8250), "od6u08jp" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8253), "xlbt1tp6" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8255), "fvq2xhz1" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9555), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9610), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9614), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9615), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9668), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9673), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9783), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9788), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9789), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9790), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9791), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9793), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9794), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9795), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9796), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9734), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9737), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9739), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5799), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5810), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5811), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5812), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5814), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5815), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5816), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5817), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5818), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5820), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5821), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5822), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5831), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5832), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5833), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5834), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5836), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5837), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5838), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5839), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5840), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5841), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5842), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5843), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5844), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5845), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5846), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5847), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5848), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5849), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5918), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6166), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(4371), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.CreateIndex(
                name: "ix_perfil_precandidatura_entidad_federativa_id",
                table: "perfil_precandidatura",
                column: "entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_precandidatura_telefono",
                table: "perfil_precandidatura",
                column: "telefono",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_perfil_url",
                table: "perfil",
                column: "url",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_perfil_persona_perfil_id",
                table: "perfil_persona",
                column: "perfil_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_perfil_persona_persona_id",
                table: "perfil_persona",
                column: "persona_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_perfil_precandidatura_entidad_federativa_entidad_federativa",
                table: "perfil_precandidatura",
                column: "entidad_federativa_id",
                principalTable: "entidad_federativa",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_perfil_precandidatura_entidad_federativa_entidad_federativa",
                table: "perfil_precandidatura");

            migrationBuilder.DropTable(
                name: "catalogo_puesto_precandidatura");

            migrationBuilder.DropTable(
                name: "perfil_persona");

            migrationBuilder.DropIndex(
                name: "ix_perfil_precandidatura_entidad_federativa_id",
                table: "perfil_precandidatura");

            migrationBuilder.DropIndex(
                name: "ix_perfil_precandidatura_telefono",
                table: "perfil_precandidatura");

            migrationBuilder.DropIndex(
                name: "ix_perfil_url",
                table: "perfil");

            migrationBuilder.DropColumn(
                name: "fecha_actualizacion",
                table: "usuario_perfil");

            migrationBuilder.DropColumn(
                name: "fecha_baja",
                table: "usuario_perfil");

            migrationBuilder.DropColumn(
                name: "fecha_actualizacion",
                table: "perfil_usuario");

            migrationBuilder.DropColumn(
                name: "fecha_baja",
                table: "perfil_usuario");

            migrationBuilder.DropColumn(
                name: "entidad_federativa_id",
                table: "perfil_precandidatura");

            migrationBuilder.DropColumn(
                name: "fecha_baja",
                table: "perfil_precandidatura");

            migrationBuilder.DropColumn(
                name: "municipio",
                table: "perfil_precandidatura");

            migrationBuilder.DropColumn(
                name: "telefono",
                table: "perfil_precandidatura");

            migrationBuilder.DropColumn(
                name: "fecha_actualizacion",
                table: "perfil_catalogo_redes_sociales");

            migrationBuilder.DropColumn(
                name: "fecha_baja",
                table: "perfil_catalogo_redes_sociales");

            migrationBuilder.DropColumn(
                name: "fecha_actualizacion",
                table: "perfil");

            migrationBuilder.DropColumn(
                name: "fecha_baja",
                table: "perfil");

            migrationBuilder.DropColumn(
                name: "fecha_actualizacion",
                table: "catalogo_redes_sociales");

            migrationBuilder.DropColumn(
                name: "fecha_baja",
                table: "catalogo_redes_sociales");

            migrationBuilder.AlterTable(
                name: "perfil",
                comment: "Debido a que cada perfil puede tener ser visitable por customurl, se establece constraint unique");

            migrationBuilder.AddColumn<string>(
                name: "alias",
                table: "perfil_precandidatura",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7857), "fd82b5o8" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7878), "ujaw44ks" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7881), "dee5de2t" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7883), "l5x2zb33" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7885), "fg89ef9a" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7888), "agq47hpf" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7890), "hxk48bu7" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6647), "3ojtp0wt" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6683), "cc77iuvz" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6686), "irlpgq7y" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6689), "otlomlt7" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6707), "exc3okuf" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8036), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8043), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8044), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5844), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5851), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5853), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5855), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5857), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5859), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5860), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5862), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5863), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5865), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5866), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5868), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5869), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5870), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5871), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5873), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5874), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5876), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5878), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5879), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5881), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5882), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5884), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5885), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5886), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5887), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5889), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5890), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5891), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5893), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5894), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5895), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5897), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5899), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5900), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5901), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5903), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5904), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5905), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5907), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5908), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5909), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5911), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5912), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5913), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5914), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5923), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5924), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5926), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5927), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5928), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5930), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5931), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5932), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5934), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5935), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5936), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5938), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5939), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5940), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5942), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5943), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5944), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5946), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5947), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5949), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5951), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5952), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5953), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5955), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5956), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5958), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5959), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5960), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5962), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5963), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5964), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5965), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5967), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5968), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5969), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5971), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5972), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5974), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5975), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5976), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5977), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5979), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5980), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5981), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5983), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5984), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5985), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5987), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5988), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5989), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5991), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5992), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5993), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5995), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5996), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5997), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5999), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6000), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6001), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6002), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6004), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6005), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6007), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6008), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6009), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6011), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6012), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6013), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6015), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6016), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6017), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6757), "5ui48oz8" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6766), "rgl6xh7u" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6769), "jjag6mrv" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6771), "8hcq3s44" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6773), "iih63kaz" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8100), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8135), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8139), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8141), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8187), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8192), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8274), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8280), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8282), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8283), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8284), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8286), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8287), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8288), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8289), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8226), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8229), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8230), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8231), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4267), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4273), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4274), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4275), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4276), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4278), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4279), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4280), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4281), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4283), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4284), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4285), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4296), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4297), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4298), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4299), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4300), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4302), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4303), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4304), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4305), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4306), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4307), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4308), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4309), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4310), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4311), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4312), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4313), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4314), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4315), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4316), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4379), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4705), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(2512), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(2515) });
        }
    }
}
