using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeCambiosJulio20231018 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cabecera_distrital",
                table: "distritos_federales",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "domicilio_general",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    direccion_completa = table.Column<string>(type: "text", nullable: false),
                    numero_calle = table.Column<string>(type: "text", nullable: true),
                    nombre_calle = table.Column<string>(type: "text", nullable: true),
                    colonia = table.Column<string>(type: "text", nullable: true),
                    ciudad = table.Column<string>(type: "text", nullable: true),
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: true),
                    codigo_postal = table.Column<string>(type: "text", nullable: true),
                    pais = table.Column<string>(type: "text", nullable: false),
                    latitud = table.Column<string>(type: "text", nullable: false),
                    longitud = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_domicilio_general", x => x.id);
                    table.ForeignKey(
                        name: "fk_domicilio_general_entidad_federativa_entidad_federativa_id",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "registro_participantes_eventos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    apellidos = table.Column<string>(type: "text", nullable: false),
                    edad = table.Column<int>(type: "integer", nullable: false),
                    genero_id = table.Column<int>(type: "integer", nullable: false),
                    correo_electronico = table.Column<string>(type: "text", nullable: false),
                    domicilio_general_id = table.Column<int>(type: "integer", nullable: false),
                    celular = table.Column<string>(type: "text", nullable: false),
                    participar_en_actividades = table.Column<bool>(type: "boolean", nullable: false),
                    movimiento_en_colonia = table.Column<bool>(type: "boolean", nullable: false),
                    representante_de_casilla = table.Column<bool>(type: "boolean", nullable: false),
                    experiencia_previa = table.Column<bool>(type: "boolean", nullable: false),
                    afiliarse_a_movimiento_ciudadano = table.Column<bool>(type: "boolean", nullable: false),
                    colocar_publicidad_en_domicilio = table.Column<bool>(type: "boolean", nullable: false),
                    nombre_evento = table.Column<string>(type: "text", nullable: false),
                    organizador_evento = table.Column<string>(type: "text", nullable: false),
                    lugar_evento = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_registro_participantes_eventos", x => x.id);
                    table.ForeignKey(
                        name: "fk_registro_participantes_eventos_domicilio_general_domicilio_",
                        column: x => x.domicilio_general_id,
                        principalTable: "domicilio_general",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_registro_participantes_eventos_genero_genero_id",
                        column: x => x.genero_id,
                        principalTable: "genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9369), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9376), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9377), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7503), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7510), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7512), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7513), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7515), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7517), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7519), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7521), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7522), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7524), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7525), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7526), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7528), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7529), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7530), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7532), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7533), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7535), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7536), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7538), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7539), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7540), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7542), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7543), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7545), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7546), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7547), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7548), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7549), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7551), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7552), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7554), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7555), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7557), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7559), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7560), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7561), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7563), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7564), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7565), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7566), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7568), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7569), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7570), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7572), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7573), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7574), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7576), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7577), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7578), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7579), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7581), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7582), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7585), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7586), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7587), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7589), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7590), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7591), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7600), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7602), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7603), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7604), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7606), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7607), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7609), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7610), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7611), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7613), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7614), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7616), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7617), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7618), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7619), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7621), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7622), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7623), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7624), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7626), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7627), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7628), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7630), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7631), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7632), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7634), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7635), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7636), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7638), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7639), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7640), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7641), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7642), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7644), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7645), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7647), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7648), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7649), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7651), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7652), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7653), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7655), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7656), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7657), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7659), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7660), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7661), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7663), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7664), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7665), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7667), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7668), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7669), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7671), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7672), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7673), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7674), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9420), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9465), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9468), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9469), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9519), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9529), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9623), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9624), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9566), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9572), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9573), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9574), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "JESUS MARIA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "AGUASCALIENTES", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "AGUASCALIENTES", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MEXICALI", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MEXICALI", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ENSENADA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TIJUANA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TIJUANA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TIJUANA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MEXICALI", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TIJUANA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TECATE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LA PAZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN JOSE DEL CABO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN FRANCISCO DE CAMPECHE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CIUDAD DEL CARMEN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PIEDRAS NEGRAS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN PEDRO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MONCLOVA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SALTILLO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TORREON", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SALTILLO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TORREON", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "RAMOS ARIZPE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "COLIMA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "VALLE DE LAS GARZAS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PALENQUE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "BOCHIL", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "OCOSINGO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PICHUCALCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN CRISTOBAL DE LAS CASAS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TONALA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TUXTLA GUTIERREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "COMITAN DE DOMINGUEZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TUXTLA GUTIERREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "VILLAFLORES", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LAS MARGARITAS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TAPACHULA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "HUEHUETAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "DELICIAS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CHIHUAHUA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CUAUHTEMOC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CHIHUAHUA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "HIDALGO DEL PARRAL", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GUSTAVO A. MADERO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GUSTAVO A. MADERO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "AZCAPOTZALCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "IZTAPALAPA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TLALPAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LA MAGDALENA CONTRERAS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GUSTAVO A. MADERO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "COYOACAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TLAHUAC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MIGUEL HIDALGO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "VENUSTIANO CARRANZA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CUAUHTEMOC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "IZTACALCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TLALPAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "BENITO JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ALVARO OBREGON", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ALVARO OBREGON", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "IZTAPALAPA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "COYOACAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "IZTAPALAPA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "XOCHIMILCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "IZTAPALAPA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "DURANGO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GOMEZ PALACIO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LERDO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "DURANGO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN LUIS DE LA PAZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN MIGUEL DE ALLENDE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LEON", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GUANAJUATO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LEON", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LEON", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN FRANCISCO DEL RINCON", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SALAMANCA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "IRAPUATO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "URIANGATO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LEON", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ACAMBARO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CELAYA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "VALLE DE SANTIAGO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "IRAPUATO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PUNGARABATO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ACAPULCO DE JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZIHUATANEJO DE AZUETA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ACAPULCO DE JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TLAPA DE COMONFORT", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CHILAPA DE ALVAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CHILPANCINGO DE LOS BRAVO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "OMETEPEC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "HUEJUTLA DE REYES", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "IXMIQUILPAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ACTOPAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TULANCINGO DE BRAVO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TULA DE ALLENDE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PACHUCA DE SOTO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TEPEAPULCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TEQUILA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LAGOS DE MORENO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TEPATITLAN DE MORELOS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZAPOPAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PUERTO VALLARTA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZAPOPAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GUADALAJARA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GUADALAJARA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZAPOPAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TONALA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GUADALAJARA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TLAJOMULCO DE ZUÑIGA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN PEDRO TLAQUEPAQUE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TLAJOMULCO DE ZUÑIGA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LA BARCA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "AUTLAN DE NAVARRO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZAPOTLAN EL GRANDE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN PEDRO TLAQUEPAQUE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "JOCOTEPEC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TONALA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "JILOTEPEC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TULTEPEC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ATLACOMULCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "NICOLAS ROMERO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TEOTIHUACAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "COACALCO DE BERRIOZABAL", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CUAUTITLAN IZCALLI", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TULTITLAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN FELIPE DEL PROGRESO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ECATEPEC DE MORELOS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ECATEPEC DE MORELOS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "IXTAPALUCA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ECATEPEC DE MORELOS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ACOLMAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ATIZAPAN DE ZARAGOZA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ECATEPEC DE MORELOS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ECATEPEC DE MORELOS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "HUIXQUILUCAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TLALNEPANTLA DE BAZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TECAMAC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "AMECAMECA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "NAUCALPAN DE JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LERMA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "NAUCALPAN DE JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CHIMALHUACAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TOLUCA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "METEPEC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZUMPANGO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "NEZAHUALCOYOTL", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CHIMALHUACAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "NEZAHUALCOYOTL", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "VALLE DE CHALCO SOLIDARIDAD", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CHALCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TOLUCA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TENANCINGO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TEJUPILCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TEOLOYUCAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TEXCOCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LA PAZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZINACANTEPEC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LAZARO CARDENAS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "APATZINGAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZITACUARO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "JIQUILPAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZAMORA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "HIDALGO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZACAPU", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MORELIA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "URUAPAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MORELIA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PATZCUARO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CUERNAVACA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "JIUTEPEC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CUAUTLA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "JOJUTLA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "YAUTEPEC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SANTIAGO IXCUINTLA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TEPIC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "COMPOSTELA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SANTA CATARINA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "APODACA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GRAL. ESCOBEDO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN NICOLAS DE LOS GARZA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MONTERREY", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MONTERREY", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GARCIA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GUADALUPE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LINARES", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MONTERREY", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GUADALUPE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SALINAS VICTORIA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PESQUERIA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN JUAN BAUTISTA TUXTEPEC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TEOTITLAN DE FLORES MAGON", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "HEROICA CIUDAD DE HUAJUAPAN DE LEON", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TLACOLULA DE MATAMOROS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SALINA CRUZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "HEROICA CIUDAD DE TLAXIACO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CIUDAD IXTEPEC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "OAXACA DE JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN PEDRO MIXTEPEC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MIAHUATLAN DE PORFIRIO DIAZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "HUAUCHINANGO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZACATLAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TEZIUTLAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "LIBRES", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN MARTIN TEXMELUCAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PUEBLA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TEPEACA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CHALCHICOMULA DE SESMA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PUEBLA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN PEDRO CHOLULA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PUEBLA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PUEBLA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ATLIXCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "IZUCAR DE MATAMOROS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TEHUACAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "AJALPAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CADEREYTA DE MONTES", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN JUAN DEL RIO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "QUERETARO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "QUERETARO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PEDRO ESCOBEDO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "QUERETARO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SOLIDARIDAD", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "OTHON P. BLANCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "BENITO JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "BENITO JUAREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MATEHUALA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SOLEDAD DE GRACIANO SANCHEZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "RIOVERDE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CIUDAD VALLES", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN LUIS POTOSI", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN LUIS POTOSI", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TAMAZUNCHALE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MAZATLAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "AHOME", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SALVADOR ALVARADO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GUASAVE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CULIACAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MAZATLAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CULIACAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN LUIS RIO COLORADO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "NOGALES", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "HERMOSILLO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GUAYMAS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "HERMOSILLO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CAJEME", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "NAVOJOA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MACUSPANA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CARDENAS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "COMALCALCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CENTRO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PARAISO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CENTRO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "NUEVO LAREDO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "REYNOSA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "RIO BRAVO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MATAMOROS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "VICTORIA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "REYNOSA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "EL MANTE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TAMPICO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "APIZACO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "TLAXCALA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZACATELCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PANUCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ALAMO TEMAPACHE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "COSOLEACAQUE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "BOCA DEL RIO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "POZA RICA DE HIDALGO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PAPANTLA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MARTINEZ DE LA TORRE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "COATEPEC", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "COATZACOALCOS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "EMILIANO ZAPATA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "XALAPA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "VERACRUZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MINATITLAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "COSAMALOAPAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZONGOLICA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "HUATUSCO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ORIZABA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "CORDOBA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "SAN ANDRES TUXTLA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "VALLADOLID", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "PROGRESO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MERIDA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MERIDA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "UMAN", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "MERIDA", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "FRESNILLO", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "JEREZ", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "ZACATECAS", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                columns: new[] { "cabecera_distrital", "fecha_creacion" },
                values: new object[] { "GUADALUPE", new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6055), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6061), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6062), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6064), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6065), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6066), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6067), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6068), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6070), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6071), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6072), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6081), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6082), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6083), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6084), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6085), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6086), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6087), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6089), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6090), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6091), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6092), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6093), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6094), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6095), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6096), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6097), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6098), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6099), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6100), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6102), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6103), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6153), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6427), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(4609), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.CreateIndex(
                name: "ix_domicilio_general_entidad_federativa_id",
                table: "domicilio_general",
                column: "entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_participantes_eventos_domicilio_general_id",
                table: "registro_participantes_eventos",
                column: "domicilio_general_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_participantes_eventos_genero_id",
                table: "registro_participantes_eventos",
                column: "genero_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "registro_participantes_eventos");

            migrationBuilder.DropTable(
                name: "domicilio_general");

            migrationBuilder.DropColumn(
                name: "cabecera_distrital",
                table: "distritos_federales");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2385), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2393), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2394), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(699), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(708), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(709), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(711), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(712), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(714), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(716), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(718), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(719), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(721), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(722), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(724), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(726), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(727), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(728), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(729), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(731), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(733), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(734), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(736), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(737), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(738), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(740), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(741), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(743), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(744), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(745), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(746), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(748), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(749), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(750), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(752), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(753), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(756), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(757), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(758), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(760), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(761), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(762), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(763), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(765), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(766), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(767), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(769), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(770), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(771), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(773), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(774), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(775), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(777), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(778), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(779), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(780), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(782), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(783), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(785), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(786), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(787), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(789), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(790), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(791), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(793), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(794), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(800), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(801), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(803), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(805), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(806), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(807), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(809), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(810), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(812), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(813), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(814), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(816), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(817), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(818), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(819), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(821), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(822), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(823), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(825), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(826), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(828), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(829), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(830), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(831), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(833), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(834), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(835), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(837), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(838), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(839), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(841), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(842), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(843), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(845), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(846), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(847), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(849), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(850), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(851), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(853), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(854), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(855), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(856), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(858), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(859), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(861), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(862), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(864), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(865), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(866), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(868), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(869), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(870), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(871), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2425), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2460), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2464), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2465), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2492), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2497), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2562), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2566), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2567), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2523), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2525), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2527), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2528), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9453), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9461), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9462), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9464), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9465), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9467), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9468), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9469), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9470), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9471), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9472), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9486), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9487), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9488), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9489), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9490), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9491), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9493), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9494), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9495), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9496), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9497), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9498), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9499), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9500), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9502), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9503), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9504), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9505), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9506), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9507), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9508), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9547), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9818), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(8183), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(8186) });
        }
    }
}
