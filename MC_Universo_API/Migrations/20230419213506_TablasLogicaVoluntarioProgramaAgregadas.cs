using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasLogicaVoluntarioProgramaAgregadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_interes_grupo_intereses",
                table: "interes_grupo_intereses");

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 4, 21 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 5, 22 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 5, 23 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 5, 24 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 5, 25 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 5, 27 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 5, 28 });

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumns: new[] { "grupo_intereses_id", "interes_id" },
                keyValues: new object[] { 5, 29 });

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "interes_grupo_intereses",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "pk_interes_grupo_intereses",
                table: "interes_grupo_intereses",
                column: "id");

            migrationBuilder.CreateTable(
                name: "area",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_area", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_categorias_preguntas_encuestas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_categorias_preguntas_encuestas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_estatus_voluntario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_estatus_voluntario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "encuesta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_encuesta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "programa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    localidad = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: true),
                    cantidad_cupo = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_programa", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_preguntas_encuestas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    categoria_pregunta_id = table.Column<int>(type: "integer", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_preguntas_encuestas", x => x.id);
                    table.ForeignKey(
                        name: "fk_catalogo_preguntas_encuestas_catalogo_categorias_preguntas_",
                        column: x => x.categoria_pregunta_id,
                        principalTable: "catalogo_categorias_preguntas_encuestas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "voluntario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    genero_id = table.Column<int>(type: "integer", nullable: false),
                    escolaridad_id = table.Column<int>(type: "integer", nullable: false),
                    motivo_id = table.Column<int>(type: "integer", nullable: false),
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: false),
                    estatus_voluntario_id = table.Column<int>(type: "integer", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    apellido_paterno = table.Column<string>(type: "text", nullable: false),
                    apellido_materno = table.Column<string>(type: "text", nullable: true),
                    direccion = table.Column<string>(type: "text", nullable: false),
                    fecha_nacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_voluntario", x => x.id);
                    table.ForeignKey(
                        name: "fk_voluntario_catalogo_estatus_voluntario_estatus_voluntario_id",
                        column: x => x.estatus_voluntario_id,
                        principalTable: "catalogo_estatus_voluntario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_voluntario_entidad_federativa_entidad_federativa_id",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_voluntario_escolaridad_escolaridad_id",
                        column: x => x.escolaridad_id,
                        principalTable: "escolaridad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_voluntario_genero_genero_id",
                        column: x => x.genero_id,
                        principalTable: "genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_voluntario_motivo_motivo_id",
                        column: x => x.motivo_id,
                        principalTable: "motivo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "programa_area",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    programa_id = table.Column<int>(type: "integer", nullable: false),
                    area_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_programa_area", x => x.id);
                    table.ForeignKey(
                        name: "fk_programa_area_area_area_id",
                        column: x => x.area_id,
                        principalTable: "area",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_programa_area_programa_programa_id",
                        column: x => x.programa_id,
                        principalTable: "programa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "programa_responsable",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    programa_id = table.Column<int>(type: "integer", nullable: false),
                    responsable_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_programa_responsable", x => x.id);
                    table.ForeignKey(
                        name: "fk_programa_responsable_programa_programa_id",
                        column: x => x.programa_id,
                        principalTable: "programa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "respuestas_encuesta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    encuesta_id = table.Column<int>(type: "integer", nullable: false),
                    pregunta_id = table.Column<int>(type: "integer", nullable: false),
                    respuesta = table.Column<string>(type: "text", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_respuestas_encuesta", x => x.id);
                    table.ForeignKey(
                        name: "fk_respuestas_encuesta_catalogo_preguntas_encuestas_pregunta_id",
                        column: x => x.pregunta_id,
                        principalTable: "catalogo_preguntas_encuestas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_respuestas_encuesta_encuesta_encuesta_id",
                        column: x => x.encuesta_id,
                        principalTable: "encuesta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "voluntario_comentario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    voluntario_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_id = table.Column<int>(type: "integer", nullable: false),
                    comentario = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_voluntario_comentario", x => x.id);
                    table.ForeignKey(
                        name: "fk_voluntario_comentario_voluntario_voluntario_id",
                        column: x => x.voluntario_id,
                        principalTable: "voluntario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "voluntario_habilidad",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    voluntario_id = table.Column<int>(type: "integer", nullable: false),
                    habilidad_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_voluntario_habilidad", x => x.id);
                    table.ForeignKey(
                        name: "fk_voluntario_habilidad_habilidad_habilidad_id",
                        column: x => x.habilidad_id,
                        principalTable: "habilidad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_voluntario_habilidad_voluntario_voluntario_id",
                        column: x => x.voluntario_id,
                        principalTable: "voluntario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "voluntario_interes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    voluntario_id = table.Column<int>(type: "integer", nullable: false),
                    interes_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_voluntario_interes", x => x.id);
                    table.ForeignKey(
                        name: "fk_voluntario_interes_interes_interes_id",
                        column: x => x.interes_id,
                        principalTable: "interes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_voluntario_interes_voluntario_voluntario_id",
                        column: x => x.voluntario_id,
                        principalTable: "voluntario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "voluntario_programa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    voluntario_id = table.Column<int>(type: "integer", nullable: false),
                    programa_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_voluntario_programa", x => x.id);
                    table.ForeignKey(
                        name: "fk_voluntario_programa_programa_programa_id",
                        column: x => x.programa_id,
                        principalTable: "programa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_voluntario_programa_voluntario_voluntario_id",
                        column: x => x.voluntario_id,
                        principalTable: "voluntario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "area",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1367), "Jóvenes" },
                    { 2, true, new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1370), "Mujeres" }
                });

            migrationBuilder.InsertData(
                table: "catalogo_categorias_preguntas_encuestas",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[] { 1, true, new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1287), "Coordinación" });

            migrationBuilder.InsertData(
                table: "catalogo_estatus_voluntario",
                columns: new[] { "id", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1338), "Por validar" },
                    { 2, new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1345), "Inválido" },
                    { 3, new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1346), "Válido" }
                });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(885), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(891), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(893), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(894), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(895), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(897), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(898), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(899), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(900), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(901), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(903), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(904), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(905), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(906), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(907), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(908), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(909), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(910), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(911), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(912), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(913), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(915), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(916), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(917), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(918), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(919), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(943), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(944), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(945), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(946), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(947), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(948), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.InsertData(
                table: "interes_grupo_intereses",
                columns: new[] { "id", "grupo_intereses_id", "interes_id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 2, 7 },
                    { 8, 2, 8 },
                    { 9, 2, 9 },
                    { 10, 2, 10 },
                    { 11, 2, 11 },
                    { 12, 2, 12 },
                    { 13, 3, 13 },
                    { 14, 3, 14 },
                    { 15, 3, 15 },
                    { 16, 3, 16 },
                    { 17, 4, 17 },
                    { 18, 4, 18 },
                    { 19, 4, 19 },
                    { 20, 4, 20 },
                    { 21, 4, 21 },
                    { 22, 5, 22 },
                    { 23, 5, 23 },
                    { 24, 5, 24 },
                    { 25, 5, 25 },
                    { 26, 5, 26 },
                    { 27, 5, 27 },
                    { 28, 5, 28 },
                    { 29, 5, 29 }
                });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(983), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1189), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 34, DateTimeKind.Utc).AddTicks(9672), new DateTime(2023, 4, 19, 21, 35, 6, 34, DateTimeKind.Utc).AddTicks(9675) });

            migrationBuilder.InsertData(
                table: "catalogo_preguntas_encuestas",
                columns: new[] { "id", "activo", "categoria_pregunta_id", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1312), "¿Cuáles son tus necesidades de capacitación?" },
                    { 2, null, 1, new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1317), "Dentro de tus conocimientos profesionales, ¿Te gustaría desarrollar algún curso?" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_interes_grupo_intereses_grupo_intereses_id",
                table: "interes_grupo_intereses",
                column: "grupo_intereses_id");

            migrationBuilder.CreateIndex(
                name: "ix_interes_grupo_intereses_interes_id",
                table: "interes_grupo_intereses",
                column: "interes_id");

            migrationBuilder.CreateIndex(
                name: "ix_catalogo_preguntas_encuestas_categoria_pregunta_id",
                table: "catalogo_preguntas_encuestas",
                column: "categoria_pregunta_id");

            migrationBuilder.CreateIndex(
                name: "ix_programa_area_area_id",
                table: "programa_area",
                column: "area_id");

            migrationBuilder.CreateIndex(
                name: "ix_programa_area_programa_id",
                table: "programa_area",
                column: "programa_id");

            migrationBuilder.CreateIndex(
                name: "ix_programa_responsable_programa_id",
                table: "programa_responsable",
                column: "programa_id");

            migrationBuilder.CreateIndex(
                name: "ix_respuestas_encuesta_encuesta_id",
                table: "respuestas_encuesta",
                column: "encuesta_id");

            migrationBuilder.CreateIndex(
                name: "ix_respuestas_encuesta_pregunta_id",
                table: "respuestas_encuesta",
                column: "pregunta_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntario_entidad_federativa_id",
                table: "voluntario",
                column: "entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntario_escolaridad_id",
                table: "voluntario",
                column: "escolaridad_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntario_estatus_voluntario_id",
                table: "voluntario",
                column: "estatus_voluntario_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntario_genero_id",
                table: "voluntario",
                column: "genero_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntario_motivo_id",
                table: "voluntario",
                column: "motivo_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntario_comentario_voluntario_id",
                table: "voluntario_comentario",
                column: "voluntario_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntario_habilidad_habilidad_id",
                table: "voluntario_habilidad",
                column: "habilidad_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntario_habilidad_voluntario_id",
                table: "voluntario_habilidad",
                column: "voluntario_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntario_interes_interes_id",
                table: "voluntario_interes",
                column: "interes_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntario_interes_voluntario_id",
                table: "voluntario_interes",
                column: "voluntario_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntario_programa_programa_id",
                table: "voluntario_programa",
                column: "programa_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntario_programa_voluntario_id",
                table: "voluntario_programa",
                column: "voluntario_id");

            migrationBuilder.AddForeignKey(
                name: "fk_interes_grupo_intereses_grupo_intereses_grupo_intereses_id",
                table: "interes_grupo_intereses",
                column: "grupo_intereses_id",
                principalTable: "grupo_intereses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_interes_grupo_intereses_interes_interes_id",
                table: "interes_grupo_intereses",
                column: "interes_id",
                principalTable: "interes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_interes_grupo_intereses_grupo_intereses_grupo_intereses_id",
                table: "interes_grupo_intereses");

            migrationBuilder.DropForeignKey(
                name: "fk_interes_grupo_intereses_interes_interes_id",
                table: "interes_grupo_intereses");

            migrationBuilder.DropTable(
                name: "programa_area");

            migrationBuilder.DropTable(
                name: "programa_responsable");

            migrationBuilder.DropTable(
                name: "respuestas_encuesta");

            migrationBuilder.DropTable(
                name: "voluntario_comentario");

            migrationBuilder.DropTable(
                name: "voluntario_habilidad");

            migrationBuilder.DropTable(
                name: "voluntario_interes");

            migrationBuilder.DropTable(
                name: "voluntario_programa");

            migrationBuilder.DropTable(
                name: "area");

            migrationBuilder.DropTable(
                name: "catalogo_preguntas_encuestas");

            migrationBuilder.DropTable(
                name: "encuesta");

            migrationBuilder.DropTable(
                name: "programa");

            migrationBuilder.DropTable(
                name: "voluntario");

            migrationBuilder.DropTable(
                name: "catalogo_categorias_preguntas_encuestas");

            migrationBuilder.DropTable(
                name: "catalogo_estatus_voluntario");

            migrationBuilder.DropPrimaryKey(
                name: "pk_interes_grupo_intereses",
                table: "interes_grupo_intereses");

            migrationBuilder.DropIndex(
                name: "ix_interes_grupo_intereses_grupo_intereses_id",
                table: "interes_grupo_intereses");

            migrationBuilder.DropIndex(
                name: "ix_interes_grupo_intereses_interes_id",
                table: "interes_grupo_intereses");

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "interes_grupo_intereses",
                keyColumn: "id",
                keyColumnType: "integer",
                keyValue: 29);

            migrationBuilder.DropColumn(
                name: "id",
                table: "interes_grupo_intereses");

            migrationBuilder.AddPrimaryKey(
                name: "pk_interes_grupo_intereses",
                table: "interes_grupo_intereses",
                columns: new[] { "interes_id", "grupo_intereses_id" });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2514), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2520), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2522), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2522), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2523), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2524), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2525), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2526), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2527), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2528), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2529), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2530), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2531), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2532), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2533), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2534), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2534), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2536), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2537), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2538), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2538), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2539), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2540), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2541), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2542), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2543), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2543), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2544), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2545), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2546), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2547), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2548), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.InsertData(
                table: "interes_grupo_intereses",
                columns: new[] { "grupo_intereses_id", "interes_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 4, 17 },
                    { 4, 18 },
                    { 4, 19 },
                    { 4, 20 },
                    { 4, 21 },
                    { 5, 22 },
                    { 5, 23 },
                    { 5, 24 },
                    { 5, 25 },
                    { 5, 26 },
                    { 5, 27 },
                    { 5, 28 },
                    { 5, 29 }
                });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2564), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2717), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(1603), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(1606) });
        }
    }
}
