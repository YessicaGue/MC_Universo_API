using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionEntidadesPersonaDireccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_avance_etapas_candidato_candidatos_chc_id_candidato_chc",
                table: "avance_etapas_candidato");

            migrationBuilder.DropForeignKey(
                name: "fk_avance_etapas_candidato_catalogo_etapas_chc_id_etapa",
                table: "avance_etapas_candidato");

            migrationBuilder.DropForeignKey(
                name: "fk_candidatos_chc_catalogo_caminos_chc_id_camino",
                table: "candidatos_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_candidatos_chc_catalogo_cargos_postulacion_id_cargo_postula",
                table: "candidatos_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_candidatos_chc_perfil_id_perfil",
                table: "candidatos_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_contenido_pantallas_etapas_chc_catalogo_caminos_chc_id_cami",
                table: "contenido_pantallas_etapas_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_contenido_pantallas_etapas_chc_catalogo_etapas_chc_id_etapa",
                table: "contenido_pantallas_etapas_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_detalle_examenes_candidatos_examenes_candidatos_id_examen_c",
                table: "detalle_examenes_candidatos");

            migrationBuilder.DropForeignKey(
                name: "fk_detalle_examenes_candidatos_respuesta_examen_chc_id_respues",
                table: "detalle_examenes_candidatos");

            migrationBuilder.DropForeignKey(
                name: "fk_direccion_entidad_federativa_entidad_federativa_id",
                table: "direccion");

            migrationBuilder.DropForeignKey(
                name: "fk_documento_candidatos_chc_candidatos_chc_id_candidato_chc",
                table: "documento_candidatos_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_examenes_candidatos_candidatos_chc_id_candidato_chc",
                table: "examenes_candidatos");

            migrationBuilder.DropForeignKey(
                name: "fk_examenes_candidatos_perfil_id_examen_chc",
                table: "examenes_candidatos");

            migrationBuilder.DropForeignKey(
                name: "fk_preguntas_examen_chc_catalogo_tipos_preguntas_id_tipo_pregu",
                table: "preguntas_examen_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_preguntas_examen_chc_examenes_chc_id_examen_chc",
                table: "preguntas_examen_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_respuesta_examen_chc_preguntas_examen_chc_id_pregunta_exame",
                table: "respuesta_examen_chc");

            migrationBuilder.DropIndex(
                name: "ix_candidatos_chc_id_camino",
                table: "candidatos_chc");

            migrationBuilder.DropIndex(
                name: "ix_candidatos_chc_id_cargo_postulacion",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "id_candidato_chc",
                table: "examenes_candidatos");

            migrationBuilder.DropColumn(
                name: "id_camino",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "id_cargo_postulacion",
                table: "candidatos_chc");

            migrationBuilder.RenameColumn(
                name: "id_pregunta_examen_chc",
                table: "respuesta_examen_chc",
                newName: "pregunta_examen_chc_id");

            migrationBuilder.RenameIndex(
                name: "ix_respuesta_examen_chc_id_pregunta_examen_chc",
                table: "respuesta_examen_chc",
                newName: "ix_respuesta_examen_chc_pregunta_examen_chc_id");

            migrationBuilder.RenameColumn(
                name: "id_tipo_pregunta",
                table: "preguntas_examen_chc",
                newName: "tipo_pregunta_id");

            migrationBuilder.RenameColumn(
                name: "id_examen_chc",
                table: "preguntas_examen_chc",
                newName: "examen_chc_id");

            migrationBuilder.RenameIndex(
                name: "ix_preguntas_examen_chc_id_tipo_pregunta",
                table: "preguntas_examen_chc",
                newName: "ix_preguntas_examen_chc_tipo_pregunta_id");

            migrationBuilder.RenameIndex(
                name: "ix_preguntas_examen_chc_id_examen_chc",
                table: "preguntas_examen_chc",
                newName: "ix_preguntas_examen_chc_examen_chc_id");

            migrationBuilder.RenameColumn(
                name: "id_examen_chc",
                table: "examenes_candidatos",
                newName: "examen_chc_id");

            migrationBuilder.RenameColumn(
                name: "id_candidato_chc1",
                table: "examenes_candidatos",
                newName: "candidato_chc_id");

            migrationBuilder.RenameIndex(
                name: "ix_examenes_candidatos_id_examen_chc",
                table: "examenes_candidatos",
                newName: "ix_examenes_candidatos_examen_chc_id");

            migrationBuilder.RenameIndex(
                name: "ix_examenes_candidatos_id_candidato_chc",
                table: "examenes_candidatos",
                newName: "ix_examenes_candidatos_candidato_chc_id");

            migrationBuilder.RenameColumn(
                name: "id_estatus_documento_eligibilidad_chc",
                table: "documento_candidatos_chc",
                newName: "estatus_documento_eligibilidad_chc_id");

            migrationBuilder.RenameColumn(
                name: "id_documento_eligibilidad_chc",
                table: "documento_candidatos_chc",
                newName: "documento_eligibilidad_chc_id");

            migrationBuilder.RenameColumn(
                name: "id_candidato_chc",
                table: "documento_candidatos_chc",
                newName: "candidato_chc_id");

            migrationBuilder.RenameIndex(
                name: "ix_documento_candidatos_chc_id_estatus_documento_eligibilidad_",
                table: "documento_candidatos_chc",
                newName: "ix_documento_candidatos_chc_estatus_documento_eligibilidad_chc");

            migrationBuilder.RenameIndex(
                name: "ix_documento_candidatos_chc_id_documento_eligibilidad_chc",
                table: "documento_candidatos_chc",
                newName: "ix_documento_candidatos_chc_documento_eligibilidad_chc_id");

            migrationBuilder.RenameIndex(
                name: "ix_documento_candidatos_chc_id_candidato_chc",
                table: "documento_candidatos_chc",
                newName: "ix_documento_candidatos_chc_candidato_chc_id");

            migrationBuilder.RenameColumn(
                name: "id_respuesta_examen_chc",
                table: "detalle_examenes_candidatos",
                newName: "respuesta_examen_chc_id");

            migrationBuilder.RenameColumn(
                name: "id_examen_candidato",
                table: "detalle_examenes_candidatos",
                newName: "examen_candidato_id");

            migrationBuilder.RenameIndex(
                name: "ix_detalle_examenes_candidatos_id_respuesta_examen_chc",
                table: "detalle_examenes_candidatos",
                newName: "ix_detalle_examenes_candidatos_respuesta_examen_chc_id");

            migrationBuilder.RenameIndex(
                name: "ix_detalle_examenes_candidatos_id_examen_candidato",
                table: "detalle_examenes_candidatos",
                newName: "ix_detalle_examenes_candidatos_examen_candidato_id");

            migrationBuilder.RenameColumn(
                name: "id_etapa",
                table: "contenido_pantallas_etapas_chc",
                newName: "etapa_id");

            migrationBuilder.RenameColumn(
                name: "id_camino",
                table: "contenido_pantallas_etapas_chc",
                newName: "camino_id");

            migrationBuilder.RenameIndex(
                name: "ix_contenido_pantallas_etapas_chc_id_etapa",
                table: "contenido_pantallas_etapas_chc",
                newName: "ix_contenido_pantallas_etapas_chc_etapa_id");

            migrationBuilder.RenameIndex(
                name: "ix_contenido_pantallas_etapas_chc_id_camino",
                table: "contenido_pantallas_etapas_chc",
                newName: "ix_contenido_pantallas_etapas_chc_camino_id");

            migrationBuilder.RenameColumn(
                name: "id_perfil",
                table: "candidatos_chc",
                newName: "perfil_id");

            migrationBuilder.RenameIndex(
                name: "ix_candidatos_chc_id_perfil",
                table: "candidatos_chc",
                newName: "ix_candidatos_chc_perfil_id");

            migrationBuilder.RenameColumn(
                name: "id_etapa",
                table: "avance_etapas_candidato",
                newName: "etapa_id");

            migrationBuilder.RenameColumn(
                name: "id_candidato_chc",
                table: "avance_etapas_candidato",
                newName: "candidato_chc_id");

            migrationBuilder.RenameIndex(
                name: "ix_avance_etapas_candidato_id_etapa",
                table: "avance_etapas_candidato",
                newName: "ix_avance_etapas_candidato_etapa_id");

            migrationBuilder.RenameIndex(
                name: "ix_avance_etapas_candidato_id_candidato_chc",
                table: "avance_etapas_candidato",
                newName: "ix_avance_etapas_candidato_candidato_chc_id");

            migrationBuilder.AddColumn<bool>(
                name: "activo",
                table: "persona",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "apodo",
                table: "persona",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "clave_elector",
                table: "persona",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "genero_id",
                table: "persona",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "rfc",
                table: "persona",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "entidad_federativa_id",
                table: "direccion",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "ciudad",
                table: "direccion",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "camino_id",
                table: "candidatos_chc",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cargo_postulacion_id",
                table: "candidatos_chc",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "persona_perfil_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_persona_perfil_chc", x => x.id);
                    table.ForeignKey(
                        name: "fk_persona_perfil_chc_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_persona_perfil_chc_persona_persona_id",
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
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9275), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9282), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9284), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9287), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9288), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9290), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9291), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9292), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9293), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9295), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9296), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9297), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9298), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9331), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9333), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9334), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9335), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9337), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9338), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9340), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9341), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9342), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9343), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9344), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9345), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9346), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9348), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9349), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9350), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9351), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9352), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9353), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9354), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9356), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9357), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9358), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9359), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9361), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9362), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9363), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9364), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9365), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9366), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9367), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9369), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9371), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9372), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9373), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9374), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9375), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9376), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9377), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9379), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9381), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9382), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9383), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9384), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9385), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9387), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9388), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9389), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9391), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9393), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9394), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9395), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9396), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9397), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9399), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9400), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9401), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9402), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9403), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9404), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9405), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9406), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9407), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9409), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9410), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9411), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9412), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9413), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9414), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9415), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9416), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9418), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9419), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9420), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9421), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9422), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9451), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9453), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9454), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9455), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9456), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9457), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9458), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9459), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9461), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9463), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9464), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9465), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9466), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9467), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9468), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(7997), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8004), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8005), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8006), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8008), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8009), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8012), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8013), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8014), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8015), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8016), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8017), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8018), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8019), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8020), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8021), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8052), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8054), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8055), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8056), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8057), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8058), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8059), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8060), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8061), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8062), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8063), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8064), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8065), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8066), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8067), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "activo", "apodo", "clave_elector", "fecha_creacion", "fecha_modificacion", "genero_id", "rfc" },
                values: new object[] { true, null, null, new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8112), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8112), null, null });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "activo", "apodo", "clave_elector", "fecha_creacion", "fecha_modificacion", "genero_id", "rfc" },
                values: new object[] { true, null, null, new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8352), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8352), null, null });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(6431), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.CreateIndex(
                name: "ix_persona_genero_id",
                table: "persona",
                column: "genero_id");

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_chc_camino_id",
                table: "candidatos_chc",
                column: "camino_id");

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_chc_cargo_postulacion_id",
                table: "candidatos_chc",
                column: "cargo_postulacion_id");

            migrationBuilder.CreateIndex(
                name: "ix_persona_perfil_chc_perfil_id",
                table: "persona_perfil_chc",
                column: "perfil_id");

            migrationBuilder.CreateIndex(
                name: "ix_persona_perfil_chc_persona_id",
                table: "persona_perfil_chc",
                column: "persona_id");

            migrationBuilder.AddForeignKey(
                name: "fk_avance_etapas_candidato_candidatos_chc_candidato_chc_id",
                table: "avance_etapas_candidato",
                column: "candidato_chc_id",
                principalTable: "candidatos_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_avance_etapas_candidato_catalogo_etapas_chc_etapa_id",
                table: "avance_etapas_candidato",
                column: "etapa_id",
                principalTable: "catalogo_etapas_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_candidatos_chc_catalogo_caminos_chc_camino_id",
                table: "candidatos_chc",
                column: "camino_id",
                principalTable: "catalogo_caminos_chc",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_candidatos_chc_catalogo_cargos_postulacion_cargo_postulacio",
                table: "candidatos_chc",
                column: "cargo_postulacion_id",
                principalTable: "catalogo_cargos_postulacion",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_candidatos_chc_perfil_perfil_id",
                table: "candidatos_chc",
                column: "perfil_id",
                principalTable: "perfil",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_contenido_pantallas_etapas_chc_catalogo_caminos_chc_camino_",
                table: "contenido_pantallas_etapas_chc",
                column: "camino_id",
                principalTable: "catalogo_caminos_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_contenido_pantallas_etapas_chc_catalogo_etapas_chc_etapa_id",
                table: "contenido_pantallas_etapas_chc",
                column: "etapa_id",
                principalTable: "catalogo_etapas_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_detalle_examenes_candidatos_examenes_candidatos_examen_cand",
                table: "detalle_examenes_candidatos",
                column: "examen_candidato_id",
                principalTable: "examenes_candidatos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_detalle_examenes_candidatos_respuesta_examen_chc_respuesta_",
                table: "detalle_examenes_candidatos",
                column: "respuesta_examen_chc_id",
                principalTable: "respuesta_examen_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_direccion_entidad_federativa_entidad_federativa_id",
                table: "direccion",
                column: "entidad_federativa_id",
                principalTable: "entidad_federativa",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_documento_candidatos_chc_candidatos_chc_candidato_chc_id",
                table: "documento_candidatos_chc",
                column: "candidato_chc_id",
                principalTable: "candidatos_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_examenes_candidatos_candidatos_chc_candidato_chc_id",
                table: "examenes_candidatos",
                column: "candidato_chc_id",
                principalTable: "candidatos_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_examenes_candidatos_perfil_examen_chc_id",
                table: "examenes_candidatos",
                column: "examen_chc_id",
                principalTable: "perfil",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_persona_genero_genero_id",
                table: "persona",
                column: "genero_id",
                principalTable: "genero",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_preguntas_examen_chc_catalogo_tipos_preguntas_tipo_pregunta",
                table: "preguntas_examen_chc",
                column: "tipo_pregunta_id",
                principalTable: "catalogo_tipos_preguntas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_preguntas_examen_chc_examenes_chc_examen_chc_id",
                table: "preguntas_examen_chc",
                column: "examen_chc_id",
                principalTable: "examenes_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_respuesta_examen_chc_preguntas_examen_chc_pregunta_examen_c",
                table: "respuesta_examen_chc",
                column: "pregunta_examen_chc_id",
                principalTable: "preguntas_examen_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_avance_etapas_candidato_candidatos_chc_candidato_chc_id",
                table: "avance_etapas_candidato");

            migrationBuilder.DropForeignKey(
                name: "fk_avance_etapas_candidato_catalogo_etapas_chc_etapa_id",
                table: "avance_etapas_candidato");

            migrationBuilder.DropForeignKey(
                name: "fk_candidatos_chc_catalogo_caminos_chc_camino_id",
                table: "candidatos_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_candidatos_chc_catalogo_cargos_postulacion_cargo_postulacio",
                table: "candidatos_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_candidatos_chc_perfil_perfil_id",
                table: "candidatos_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_contenido_pantallas_etapas_chc_catalogo_caminos_chc_camino_",
                table: "contenido_pantallas_etapas_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_contenido_pantallas_etapas_chc_catalogo_etapas_chc_etapa_id",
                table: "contenido_pantallas_etapas_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_detalle_examenes_candidatos_examenes_candidatos_examen_cand",
                table: "detalle_examenes_candidatos");

            migrationBuilder.DropForeignKey(
                name: "fk_detalle_examenes_candidatos_respuesta_examen_chc_respuesta_",
                table: "detalle_examenes_candidatos");

            migrationBuilder.DropForeignKey(
                name: "fk_direccion_entidad_federativa_entidad_federativa_id",
                table: "direccion");

            migrationBuilder.DropForeignKey(
                name: "fk_documento_candidatos_chc_candidatos_chc_candidato_chc_id",
                table: "documento_candidatos_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_examenes_candidatos_candidatos_chc_candidato_chc_id",
                table: "examenes_candidatos");

            migrationBuilder.DropForeignKey(
                name: "fk_examenes_candidatos_perfil_examen_chc_id",
                table: "examenes_candidatos");

            migrationBuilder.DropForeignKey(
                name: "fk_persona_genero_genero_id",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "fk_preguntas_examen_chc_catalogo_tipos_preguntas_tipo_pregunta",
                table: "preguntas_examen_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_preguntas_examen_chc_examenes_chc_examen_chc_id",
                table: "preguntas_examen_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_respuesta_examen_chc_preguntas_examen_chc_pregunta_examen_c",
                table: "respuesta_examen_chc");

            migrationBuilder.DropTable(
                name: "persona_perfil_chc");

            migrationBuilder.DropIndex(
                name: "ix_persona_genero_id",
                table: "persona");

            migrationBuilder.DropIndex(
                name: "ix_candidatos_chc_camino_id",
                table: "candidatos_chc");

            migrationBuilder.DropIndex(
                name: "ix_candidatos_chc_cargo_postulacion_id",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "activo",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "apodo",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "clave_elector",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "genero_id",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "rfc",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "camino_id",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "cargo_postulacion_id",
                table: "candidatos_chc");

            migrationBuilder.RenameColumn(
                name: "pregunta_examen_chc_id",
                table: "respuesta_examen_chc",
                newName: "id_pregunta_examen_chc");

            migrationBuilder.RenameIndex(
                name: "ix_respuesta_examen_chc_pregunta_examen_chc_id",
                table: "respuesta_examen_chc",
                newName: "ix_respuesta_examen_chc_id_pregunta_examen_chc");

            migrationBuilder.RenameColumn(
                name: "tipo_pregunta_id",
                table: "preguntas_examen_chc",
                newName: "id_tipo_pregunta");

            migrationBuilder.RenameColumn(
                name: "examen_chc_id",
                table: "preguntas_examen_chc",
                newName: "id_examen_chc");

            migrationBuilder.RenameIndex(
                name: "ix_preguntas_examen_chc_tipo_pregunta_id",
                table: "preguntas_examen_chc",
                newName: "ix_preguntas_examen_chc_id_tipo_pregunta");

            migrationBuilder.RenameIndex(
                name: "ix_preguntas_examen_chc_examen_chc_id",
                table: "preguntas_examen_chc",
                newName: "ix_preguntas_examen_chc_id_examen_chc");

            migrationBuilder.RenameColumn(
                name: "examen_chc_id",
                table: "examenes_candidatos",
                newName: "id_examen_chc");

            migrationBuilder.RenameColumn(
                name: "candidato_chc_id",
                table: "examenes_candidatos",
                newName: "id_candidato_chc1");

            migrationBuilder.RenameIndex(
                name: "ix_examenes_candidatos_examen_chc_id",
                table: "examenes_candidatos",
                newName: "ix_examenes_candidatos_id_examen_chc");

            migrationBuilder.RenameIndex(
                name: "ix_examenes_candidatos_candidato_chc_id",
                table: "examenes_candidatos",
                newName: "ix_examenes_candidatos_id_candidato_chc");

            migrationBuilder.RenameColumn(
                name: "estatus_documento_eligibilidad_chc_id",
                table: "documento_candidatos_chc",
                newName: "id_estatus_documento_eligibilidad_chc");

            migrationBuilder.RenameColumn(
                name: "documento_eligibilidad_chc_id",
                table: "documento_candidatos_chc",
                newName: "id_documento_eligibilidad_chc");

            migrationBuilder.RenameColumn(
                name: "candidato_chc_id",
                table: "documento_candidatos_chc",
                newName: "id_candidato_chc");

            migrationBuilder.RenameIndex(
                name: "ix_documento_candidatos_chc_estatus_documento_eligibilidad_chc",
                table: "documento_candidatos_chc",
                newName: "ix_documento_candidatos_chc_id_estatus_documento_eligibilidad_");

            migrationBuilder.RenameIndex(
                name: "ix_documento_candidatos_chc_documento_eligibilidad_chc_id",
                table: "documento_candidatos_chc",
                newName: "ix_documento_candidatos_chc_id_documento_eligibilidad_chc");

            migrationBuilder.RenameIndex(
                name: "ix_documento_candidatos_chc_candidato_chc_id",
                table: "documento_candidatos_chc",
                newName: "ix_documento_candidatos_chc_id_candidato_chc");

            migrationBuilder.RenameColumn(
                name: "respuesta_examen_chc_id",
                table: "detalle_examenes_candidatos",
                newName: "id_respuesta_examen_chc");

            migrationBuilder.RenameColumn(
                name: "examen_candidato_id",
                table: "detalle_examenes_candidatos",
                newName: "id_examen_candidato");

            migrationBuilder.RenameIndex(
                name: "ix_detalle_examenes_candidatos_respuesta_examen_chc_id",
                table: "detalle_examenes_candidatos",
                newName: "ix_detalle_examenes_candidatos_id_respuesta_examen_chc");

            migrationBuilder.RenameIndex(
                name: "ix_detalle_examenes_candidatos_examen_candidato_id",
                table: "detalle_examenes_candidatos",
                newName: "ix_detalle_examenes_candidatos_id_examen_candidato");

            migrationBuilder.RenameColumn(
                name: "etapa_id",
                table: "contenido_pantallas_etapas_chc",
                newName: "id_etapa");

            migrationBuilder.RenameColumn(
                name: "camino_id",
                table: "contenido_pantallas_etapas_chc",
                newName: "id_camino");

            migrationBuilder.RenameIndex(
                name: "ix_contenido_pantallas_etapas_chc_etapa_id",
                table: "contenido_pantallas_etapas_chc",
                newName: "ix_contenido_pantallas_etapas_chc_id_etapa");

            migrationBuilder.RenameIndex(
                name: "ix_contenido_pantallas_etapas_chc_camino_id",
                table: "contenido_pantallas_etapas_chc",
                newName: "ix_contenido_pantallas_etapas_chc_id_camino");

            migrationBuilder.RenameColumn(
                name: "perfil_id",
                table: "candidatos_chc",
                newName: "id_perfil");

            migrationBuilder.RenameIndex(
                name: "ix_candidatos_chc_perfil_id",
                table: "candidatos_chc",
                newName: "ix_candidatos_chc_id_perfil");

            migrationBuilder.RenameColumn(
                name: "etapa_id",
                table: "avance_etapas_candidato",
                newName: "id_etapa");

            migrationBuilder.RenameColumn(
                name: "candidato_chc_id",
                table: "avance_etapas_candidato",
                newName: "id_candidato_chc");

            migrationBuilder.RenameIndex(
                name: "ix_avance_etapas_candidato_etapa_id",
                table: "avance_etapas_candidato",
                newName: "ix_avance_etapas_candidato_id_etapa");

            migrationBuilder.RenameIndex(
                name: "ix_avance_etapas_candidato_candidato_chc_id",
                table: "avance_etapas_candidato",
                newName: "ix_avance_etapas_candidato_id_candidato_chc");

            migrationBuilder.AddColumn<int>(
                name: "id_candidato_chc",
                table: "examenes_candidatos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "entidad_federativa_id",
                table: "direccion",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ciudad",
                table: "direccion",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_camino",
                table: "candidatos_chc",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_cargo_postulacion",
                table: "candidatos_chc",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3805), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3810), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3812), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3813), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3815), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3817), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3818), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3820), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3821), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3823), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3825), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3826), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3827), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3828), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3830), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3831), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3832), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3835), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3836), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3837), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3839), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3840), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3842), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3843), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3844), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3846), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3847), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3848), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3849), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3851), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3852), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3853), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3855), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3858), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3859), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3860), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3861), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3863), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3864), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3865), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3866), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3868), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3869), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3870), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3871), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3873), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3874), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3875), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3876), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3878), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3879), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3880), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3882), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3883), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3884), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3885), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3887), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3888), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3889), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3890), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3892), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3893), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3894), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3896), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3897), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3970), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3971), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3973), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3974), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3975), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3977), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3978), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3979), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3980), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3982), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3983), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3984), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3986), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3987), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3988), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3991), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3992), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3994), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3995), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3996), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3997), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3999), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4000), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4001), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4002), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4004), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4005), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4006), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4008), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4009), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4010), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4012), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4013), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4014), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4015), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4017), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4018), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4019), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4020), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4022), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4023), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4024), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4026), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1821), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1828), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1829), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1831), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1832), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1834), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1835), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1836), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1837), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1839), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1840), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1841), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1848), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1849), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1850), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1851), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1852), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1854), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1855), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1857), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1858), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1859), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1860), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1861), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1862), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1863), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1864), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1866), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1867), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1868), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1869), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1870), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1937), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2310), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 155, DateTimeKind.Utc).AddTicks(9799), new DateTime(2023, 8, 7, 19, 34, 12, 155, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_chc_id_camino",
                table: "candidatos_chc",
                column: "id_camino");

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_chc_id_cargo_postulacion",
                table: "candidatos_chc",
                column: "id_cargo_postulacion");

            migrationBuilder.AddForeignKey(
                name: "fk_avance_etapas_candidato_candidatos_chc_id_candidato_chc",
                table: "avance_etapas_candidato",
                column: "id_candidato_chc",
                principalTable: "candidatos_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_avance_etapas_candidato_catalogo_etapas_chc_id_etapa",
                table: "avance_etapas_candidato",
                column: "id_etapa",
                principalTable: "catalogo_etapas_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_candidatos_chc_catalogo_caminos_chc_id_camino",
                table: "candidatos_chc",
                column: "id_camino",
                principalTable: "catalogo_caminos_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_candidatos_chc_catalogo_cargos_postulacion_id_cargo_postula",
                table: "candidatos_chc",
                column: "id_cargo_postulacion",
                principalTable: "catalogo_cargos_postulacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_candidatos_chc_perfil_id_perfil",
                table: "candidatos_chc",
                column: "id_perfil",
                principalTable: "perfil",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_contenido_pantallas_etapas_chc_catalogo_caminos_chc_id_cami",
                table: "contenido_pantallas_etapas_chc",
                column: "id_camino",
                principalTable: "catalogo_caminos_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_contenido_pantallas_etapas_chc_catalogo_etapas_chc_id_etapa",
                table: "contenido_pantallas_etapas_chc",
                column: "id_etapa",
                principalTable: "catalogo_etapas_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_detalle_examenes_candidatos_examenes_candidatos_id_examen_c",
                table: "detalle_examenes_candidatos",
                column: "id_examen_candidato",
                principalTable: "examenes_candidatos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_detalle_examenes_candidatos_respuesta_examen_chc_id_respues",
                table: "detalle_examenes_candidatos",
                column: "id_respuesta_examen_chc",
                principalTable: "respuesta_examen_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_direccion_entidad_federativa_entidad_federativa_id",
                table: "direccion",
                column: "entidad_federativa_id",
                principalTable: "entidad_federativa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_documento_candidatos_chc_candidatos_chc_id_candidato_chc",
                table: "documento_candidatos_chc",
                column: "id_candidato_chc",
                principalTable: "candidatos_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_examenes_candidatos_candidatos_chc_id_candidato_chc",
                table: "examenes_candidatos",
                column: "id_candidato_chc1",
                principalTable: "candidatos_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_examenes_candidatos_perfil_id_examen_chc",
                table: "examenes_candidatos",
                column: "id_examen_chc",
                principalTable: "perfil",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_preguntas_examen_chc_catalogo_tipos_preguntas_id_tipo_pregu",
                table: "preguntas_examen_chc",
                column: "id_tipo_pregunta",
                principalTable: "catalogo_tipos_preguntas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_preguntas_examen_chc_examenes_chc_id_examen_chc",
                table: "preguntas_examen_chc",
                column: "id_examen_chc",
                principalTable: "examenes_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_respuesta_examen_chc_preguntas_examen_chc_id_pregunta_exame",
                table: "respuesta_examen_chc",
                column: "id_pregunta_examen_chc",
                principalTable: "preguntas_examen_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
