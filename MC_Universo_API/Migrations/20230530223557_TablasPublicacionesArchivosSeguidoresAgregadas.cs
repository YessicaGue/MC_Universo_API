using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasPublicacionesArchivosSeguidoresAgregadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "archivo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    directorio = table.Column<string>(type: "text", nullable: false),
                    slug = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    es_publico = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_archivo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_publicaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_publicaciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "perfil",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    alias = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    url = table.Column<string>(type: "text", nullable: false),
                    es_publico = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "publicacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario_id = table.Column<int>(type: "integer", nullable: false),
                    catalogo_publicacion_id = table.Column<int>(type: "integer", nullable: true),
                    titulo = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    contenido = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_publicacion", x => x.id);
                    table.ForeignKey(
                        name: "fk_publicacion_catalogo_publicaciones_catalogo_publicacion_id",
                        column: x => x.catalogo_publicacion_id,
                        principalTable: "catalogo_publicaciones",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "perfil_sigue_perfil",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_seguido_id = table.Column<int>(type: "integer", nullable: false),
                    perfil_seguidor_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_sigue_perfil", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_sigue_perfil_perfil_perfil_seguido_id",
                        column: x => x.perfil_seguido_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_sigue_perfil_perfil_perfil_seguidor_id",
                        column: x => x.perfil_seguidor_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuario_perfil",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario_id = table.Column<int>(type: "integer", nullable: false),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_usuario_perfil", x => x.id);
                    table.ForeignKey(
                        name: "fk_usuario_perfil_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "publicacion_archivo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    publicacion_id = table.Column<int>(type: "integer", nullable: false),
                    archivo_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_publicacion_archivo", x => x.id);
                    table.ForeignKey(
                        name: "fk_publicacion_archivo_archivo_archivo_id",
                        column: x => x.archivo_id,
                        principalTable: "archivo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_publicacion_archivo_publicacion_publicacion_id",
                        column: x => x.publicacion_id,
                        principalTable: "publicacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.InsertData(
                table: "catalogo_publicaciones",
                columns: new[] { "id", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6716), "Mi liderazgo" },
                    { 2, new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6719), "Mi círculo" },
                    { 3, new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6720), "Mi comunidad" }
                });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6042), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6076), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6077), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6078), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6080), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6082), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6083), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6084), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6085), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6086), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6087), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6088), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6090), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6091), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6092), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6093), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6094), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6096), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6097), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6098), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6099), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6100), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6101), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6102), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6103), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6104), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6104), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6105), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6106), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6107), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6108), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6109), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6149), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6350), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(4844), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(4847) });

            migrationBuilder.CreateIndex(
                name: "ix_perfil_sigue_perfil_perfil_seguido_id",
                table: "perfil_sigue_perfil",
                column: "perfil_seguido_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_sigue_perfil_perfil_seguidor_id",
                table: "perfil_sigue_perfil",
                column: "perfil_seguidor_id");

            migrationBuilder.CreateIndex(
                name: "ix_publicacion_catalogo_publicacion_id",
                table: "publicacion",
                column: "catalogo_publicacion_id");

            migrationBuilder.CreateIndex(
                name: "ix_publicacion_archivo_archivo_id",
                table: "publicacion_archivo",
                column: "archivo_id");

            migrationBuilder.CreateIndex(
                name: "ix_publicacion_archivo_publicacion_id",
                table: "publicacion_archivo",
                column: "publicacion_id");

            migrationBuilder.CreateIndex(
                name: "ix_usuario_perfil_perfil_id",
                table: "usuario_perfil",
                column: "perfil_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "perfil_sigue_perfil");

            migrationBuilder.DropTable(
                name: "publicacion_archivo");

            migrationBuilder.DropTable(
                name: "usuario_perfil");

            migrationBuilder.DropTable(
                name: "archivo");

            migrationBuilder.DropTable(
                name: "publicacion");

            migrationBuilder.DropTable(
                name: "perfil");

            migrationBuilder.DropTable(
                name: "catalogo_publicaciones");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7578), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7585), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7586), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7587), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7588), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7589), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7590), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7616), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7617), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7618), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7619), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7620), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7621), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7622), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7623), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7625), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7626), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7627), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7628), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7629), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7630), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7631), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7632), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7634), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7635), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7636), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7637), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7638), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7639), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7640), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7641), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7680), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7903), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(6247), new DateTime(2023, 5, 16, 20, 20, 19, 617, DateTimeKind.Utc).AddTicks(6251) });
        }
    }
}
