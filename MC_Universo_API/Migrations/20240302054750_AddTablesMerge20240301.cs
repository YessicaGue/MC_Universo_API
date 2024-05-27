using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesMerge20240301 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_formulario_temas_interes_entidad_federativa_entidad_federat",
                table: "formulario_temas_interes");

            migrationBuilder.DropIndex(
                name: "ix_perfil_usuario_perfil_id",
                table: "perfil_usuario");

            migrationBuilder.AlterColumn<string>(
                name: "organizador_evento",
                table: "registro_participantes_eventos",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre_evento",
                table: "registro_participantes_eventos",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lugar_evento",
                table: "registro_participantes_eventos",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "folio",
                table: "registro_participantes_eventos",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_evento",
                table: "registro_participantes_eventos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "entidad_federativa_evento_id",
                table: "registro_participantes_eventos",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "dictaminado",
                table: "perfil_precandidatura",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "distrito",
                table: "perfil_precandidatura",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "es_publico",
                table: "perfil",
                type: "boolean",
                nullable: false,
                comment: "Esta columna indica si el perfil es publico o privado",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AddColumn<bool>(
                name: "es_candidato",
                table: "perfil",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                comment: "Esta columna indica si el perfil es un candidato aprobado.");

            migrationBuilder.AddColumn<bool>(
                name: "es_verificado",
                table: "perfil",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                comment: "Esta columna indica si el perfil es verificado.");

            migrationBuilder.AlterColumn<int>(
                name: "entidad_federativa_id",
                table: "formulario_temas_interes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<bool>(
                name: "acepto_aviso_privacidad",
                table: "formulario_temas_interes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ciudad",
                table: "formulario_temas_interes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "es_modal_apoyar_comunidad",
                table: "formulario_temas_interes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "es_modal_recibir_temas_interes",
                table: "formulario_temas_interes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "es_modal_ser_parte_equipo",
                table: "formulario_temas_interes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_nacimiento",
                table: "formulario_temas_interes",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "motivo_apoyo",
                table: "formulario_temas_interes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "nivel_escolar_id",
                table: "formulario_temas_interes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "numero_whatsapp",
                table: "formulario_temas_interes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "municipio",
                table: "domicilio_general",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "cuestionario_candidato",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    causas = table.Column<List<string>>(type: "text[]", nullable: false),
                    propuestas = table.Column<string>(type: "text", nullable: false),
                    fecha_nacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    redes_sociales = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    fecha_baja = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cuestionario_candidato", x => x.id);
                    table.ForeignKey(
                        name: "fk_cuestionario_candidato_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "entidad_federativa_codigo_eventos",
                columns: table => new
                {
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: false),
                    generador_contado_codigo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_entidad_federativa_codigo_eventos", x => x.entidad_federativa_id);
                    table.ForeignKey(
                        name: "fk_entidad_federativa_codigo_eventos_entidad_federativa_entida",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "colaborador_candidato",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uuid", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    telefono = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    cuestionario_candidato_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_colaborador_candidato", x => x.guid);
                    table.ForeignKey(
                        name: "fk_colaborador_candidato_cuestionario_candidato_cuestionario_c",
                        column: x => x.cuestionario_candidato_id,
                        principalTable: "cuestionario_candidato",
                        principalColumn: "id");
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7564), "1w1fwfte" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7581), "7tfvqt60" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7630), "znz9b36i" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7634), "77r8tbyv" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7638), "obko52e1" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7642), "9acr5w8d" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7645), "6g2ocqfu" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.InsertData(
                table: "catalogo_causas_landing",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 6, true, new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4581), "Trabajo" },
                    { 7, true, new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4581), "El campo" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6072), "qsoqfix7" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6105), "atdvj9b1" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6115), "36y1raw9" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6119), "tiuh9w69" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6150), "ywenncyf" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7821), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7828), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7829), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5106), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5115), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5117), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5120), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5121), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5123), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5125), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5126), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5128), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5130), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5132), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5133), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5134), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5136), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5137), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5139), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5140), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5142), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5144), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5146), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5148), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5149), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5151), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5152), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5154), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5155), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5156), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5158), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5159), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5161), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5162), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5164), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5165), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5168), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5169), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5171), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5172), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5173), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5175), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5177), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5178), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5180), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5181), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5183), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5184), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5186), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5187), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5188), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5190), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5200), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5201), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5203), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5204), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5206), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5207), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5209), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5210), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5212), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5214), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5215), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5216), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5218), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5219), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5221), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5222), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5224), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5226), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5227), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5229), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5231), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5232), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5234), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5235), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5237), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5238), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5240), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5241), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5243), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5244), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5245), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5247), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5249), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5250), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5252), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5254), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5257), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5259), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5260), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5262), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5263), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5264), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5266), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5267), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5269), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5270), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5272), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5273), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5275), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5276), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5277), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5279), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5281), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5282), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5284), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5285), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5286), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5288), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5290), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5291), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5293), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5294), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5296), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5297), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5299), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5300), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5302), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5303), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4505), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4506), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4507), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6215), "iau3j215" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6223), "b6xjgsm3" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6227), "iryu6oi2" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6231), "1a0xdp92" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6234), "2ubo3pia" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7884), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7943), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7948), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7949), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8177), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8181), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8306), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8312), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8313), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8314), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8315), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8317), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8319), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8320), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8321), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8237), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8240), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8242), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8243), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3120), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3126), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3128), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3129), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3130), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3132), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3133), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3135), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3136), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3138), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3139), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3150), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3151), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3152), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3154), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3155), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3156), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3158), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3159), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3160), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3161), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3162), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3163), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3165), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3166), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3167), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3168), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3169), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3170), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3173), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3174), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.InsertData(
                table: "entidad_federativa_codigo_eventos",
                columns: new[] { "entidad_federativa_id", "generador_contado_codigo" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 0 },
                    { 3, 0 },
                    { 4, 0 },
                    { 5, 0 },
                    { 6, 0 },
                    { 7, 0 },
                    { 8, 0 },
                    { 9, 0 },
                    { 10, 0 },
                    { 11, 0 },
                    { 12, 0 },
                    { 13, 0 },
                    { 14, 0 },
                    { 15, 0 },
                    { 16, 0 },
                    { 17, 0 },
                    { 18, 0 },
                    { 19, 0 },
                    { 20, 0 },
                    { 21, 0 },
                    { 22, 0 },
                    { 23, 0 },
                    { 24, 0 },
                    { 25, 0 },
                    { 26, 0 },
                    { 27, 0 },
                    { 28, 0 },
                    { 29, 0 },
                    { 30, 0 },
                    { 31, 0 },
                    { 32, 0 }
                });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3245), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3642), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(1141), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.CreateIndex(
                name: "ix_registro_participantes_eventos_entidad_federativa_evento_id",
                table: "registro_participantes_eventos",
                column: "entidad_federativa_evento_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_usuario_email",
                table: "perfil_usuario",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_perfil_usuario_perfil_id",
                table: "perfil_usuario",
                column: "perfil_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_formulario_temas_interes_nivel_escolar_id",
                table: "formulario_temas_interes",
                column: "nivel_escolar_id");

            migrationBuilder.CreateIndex(
                name: "ix_colaborador_candidato_cuestionario_candidato_id",
                table: "colaborador_candidato",
                column: "cuestionario_candidato_id");

            migrationBuilder.CreateIndex(
                name: "ix_cuestionario_candidato_perfil_id",
                table: "cuestionario_candidato",
                column: "perfil_id");

            migrationBuilder.AddForeignKey(
                name: "fk_formulario_temas_interes_entidad_federativa_entidad_federat",
                table: "formulario_temas_interes",
                column: "entidad_federativa_id",
                principalTable: "entidad_federativa",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_formulario_temas_interes_escolaridad_nivel_escolar_id",
                table: "formulario_temas_interes",
                column: "nivel_escolar_id",
                principalTable: "escolaridad",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_registro_participantes_eventos_entidad_federativa_entidad_f",
                table: "registro_participantes_eventos",
                column: "entidad_federativa_evento_id",
                principalTable: "entidad_federativa",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_formulario_temas_interes_entidad_federativa_entidad_federat",
                table: "formulario_temas_interes");

            migrationBuilder.DropForeignKey(
                name: "fk_formulario_temas_interes_escolaridad_nivel_escolar_id",
                table: "formulario_temas_interes");

            migrationBuilder.DropForeignKey(
                name: "fk_registro_participantes_eventos_entidad_federativa_entidad_f",
                table: "registro_participantes_eventos");

            migrationBuilder.DropTable(
                name: "colaborador_candidato");

            migrationBuilder.DropTable(
                name: "entidad_federativa_codigo_eventos");

            migrationBuilder.DropTable(
                name: "cuestionario_candidato");

            migrationBuilder.DropIndex(
                name: "ix_registro_participantes_eventos_entidad_federativa_evento_id",
                table: "registro_participantes_eventos");

            migrationBuilder.DropIndex(
                name: "ix_perfil_usuario_email",
                table: "perfil_usuario");

            migrationBuilder.DropIndex(
                name: "ix_perfil_usuario_perfil_id",
                table: "perfil_usuario");

            migrationBuilder.DropIndex(
                name: "ix_formulario_temas_interes_nivel_escolar_id",
                table: "formulario_temas_interes");

            migrationBuilder.DeleteData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "entidad_federativa_evento_id",
                table: "registro_participantes_eventos");

            migrationBuilder.DropColumn(
                name: "dictaminado",
                table: "perfil_precandidatura");

            migrationBuilder.DropColumn(
                name: "distrito",
                table: "perfil_precandidatura");

            migrationBuilder.DropColumn(
                name: "es_candidato",
                table: "perfil");

            migrationBuilder.DropColumn(
                name: "es_verificado",
                table: "perfil");

            migrationBuilder.DropColumn(
                name: "acepto_aviso_privacidad",
                table: "formulario_temas_interes");

            migrationBuilder.DropColumn(
                name: "ciudad",
                table: "formulario_temas_interes");

            migrationBuilder.DropColumn(
                name: "es_modal_apoyar_comunidad",
                table: "formulario_temas_interes");

            migrationBuilder.DropColumn(
                name: "es_modal_recibir_temas_interes",
                table: "formulario_temas_interes");

            migrationBuilder.DropColumn(
                name: "es_modal_ser_parte_equipo",
                table: "formulario_temas_interes");

            migrationBuilder.DropColumn(
                name: "fecha_nacimiento",
                table: "formulario_temas_interes");

            migrationBuilder.DropColumn(
                name: "motivo_apoyo",
                table: "formulario_temas_interes");

            migrationBuilder.DropColumn(
                name: "nivel_escolar_id",
                table: "formulario_temas_interes");

            migrationBuilder.DropColumn(
                name: "numero_whatsapp",
                table: "formulario_temas_interes");

            migrationBuilder.DropColumn(
                name: "municipio",
                table: "domicilio_general");

            migrationBuilder.AlterColumn<string>(
                name: "organizador_evento",
                table: "registro_participantes_eventos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "nombre_evento",
                table: "registro_participantes_eventos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "lugar_evento",
                table: "registro_participantes_eventos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "folio",
                table: "registro_participantes_eventos",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_evento",
                table: "registro_participantes_eventos",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<bool>(
                name: "es_publico",
                table: "perfil",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldComment: "Esta columna indica si el perfil es publico o privado");

            migrationBuilder.AlterColumn<int>(
                name: "entidad_federativa_id",
                table: "formulario_temas_interes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4769), "xbdz0e6c" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4793), "szfrojvr" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4799), "zm8jqy5t" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4803), "s9jhgowq" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4807), "euq7vnhb" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4811), "a4uepfd2" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4814), "ad7mzpgi" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2962), "d5ngohsu" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3001), "umfwrr43" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3005), "hozc57u3" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3009), "30q8tctm" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3031), "z29c9bqm" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5057), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5069), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5070), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1760), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1772), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1774), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1776), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1778), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1781), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1782), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1784), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1786), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1799), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1800), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1802), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1803), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1805), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1806), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1808), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1810), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1813), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1814), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1816), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1817), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1819), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1822), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1824), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1825), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1827), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1828), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1834), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1835), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1837), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1839), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1840), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1843), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1844), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1846), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1847), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1849), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1850), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1852), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1853), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1855), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1856), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1858), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1859), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1861), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1863), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1864), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1866), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1867), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1869), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1870), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1872), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1873), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1875), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1877), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1878), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1880), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1882), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1883), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1885), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1887), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1888), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1890), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1891), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1893), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1895), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1896), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1898), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1900), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1901), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1903), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1905), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1906), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1914), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1916), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1917), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1938), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1941), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1943), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1945), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1946), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1948), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1949), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1952), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1954), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1955), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1957), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1960), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1961), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1963), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1965), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1966), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1968), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1970), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1971), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1973), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1974), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1976), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1977), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1979), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1982), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1984), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1986), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1987), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1989), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1990), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1992), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1993), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1995), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1997), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1998), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2000), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2001), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1003), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1013), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1014), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1015), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1017), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3118), "veqk27zx" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3133), "myjpslct" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3138), "vbxf16el" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3142), "zy7ajjke" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3146), "1vsynaqg" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5143), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5225), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5232), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5233), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5306), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5314), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5639), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5648), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5649), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5651), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5652), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5654), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5656), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5657), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5658), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5544), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5556), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5557), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5558), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9311), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9330), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9331), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9333), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9334), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9337), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9338), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9339), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9342), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9344), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9345), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9346), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9348), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9350), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9351), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9352), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9364), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9365), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9367), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9368), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9369), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9371), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9372), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9373), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9374), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9376), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9377), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9379), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9380), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9381), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9382), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9477), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9861), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(7092), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(7096) });

            migrationBuilder.CreateIndex(
                name: "ix_perfil_usuario_perfil_id",
                table: "perfil_usuario",
                column: "perfil_id");

            migrationBuilder.AddForeignKey(
                name: "fk_formulario_temas_interes_entidad_federativa_entidad_federat",
                table: "formulario_temas_interes",
                column: "entidad_federativa_id",
                principalTable: "entidad_federativa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
