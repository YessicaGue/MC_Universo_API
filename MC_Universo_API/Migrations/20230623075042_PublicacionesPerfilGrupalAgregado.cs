using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class PublicacionesPerfilGrupalAgregado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catalogo_publicaciones_perfil_grupal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_publicaciones_perfil_grupal", x => x.id);
                });

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
                name: "publicacion_perfil_grupal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_grupal_id = table.Column<int>(type: "integer", nullable: false),
                    catalogo_publicacion_perfil_grupal_id = table.Column<int>(type: "integer", nullable: true),
                    titulo = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    contenido = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    url = table.Column<string>(type: "text", nullable: true),
                    imagen_publicacion = table.Column<string>(type: "text", nullable: true),
                    fecha_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_publicacion_perfil_grupal", x => x.id);
                    table.ForeignKey(
                        name: "fk_publicacion_perfil_grupal_catalogo_publicaciones_perfil_gru",
                        column: x => x.catalogo_publicacion_perfil_grupal_id,
                        principalTable: "catalogo_publicaciones_perfil_grupal",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_publicacion_perfil_grupal_perfil_grupal_perfil_grupal_id",
                        column: x => x.perfil_grupal_id,
                        principalTable: "perfil_grupal",
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
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.InsertData(
                table: "catalogo_publicaciones_perfil_grupal",
                columns: new[] { "id", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5491), "Movimiento social" },
                    { 2, new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5495), "Nuestro trabajo" },
                    { 3, new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5496), "Lo más reciente" },
                    { 4, new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5497), "Próximos eventos" },
                    { 5, new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5497), "Próximos cursos" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4558), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4562), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4564), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4565), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4566), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4568), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4569), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4570), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4571), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4621), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4626), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4627), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4628), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4629), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4630), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4631), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4632), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4634), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4636), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4637), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4638), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4639), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4640), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4641), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4642), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4643), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4644), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4645), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4646), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4647), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4648), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4649), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4687), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4917), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(3109), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(3114) });

            migrationBuilder.CreateIndex(
                name: "ix_perfil_sigue_perfil_grupal_perfil_grupal_seguido_id",
                table: "perfil_sigue_perfil_grupal",
                column: "perfil_grupal_seguido_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_sigue_perfil_grupal_perfil_seguidor_id",
                table: "perfil_sigue_perfil_grupal",
                column: "perfil_seguidor_id");

            migrationBuilder.CreateIndex(
                name: "ix_publicacion_perfil_grupal_catalogo_publicacion_perfil_grupa",
                table: "publicacion_perfil_grupal",
                column: "catalogo_publicacion_perfil_grupal_id");

            migrationBuilder.CreateIndex(
                name: "ix_publicacion_perfil_grupal_perfil_grupal_id",
                table: "publicacion_perfil_grupal",
                column: "perfil_grupal_id");

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
                name: "publicacion_perfil_grupal");

            migrationBuilder.DropTable(
                name: "usuario_perfil_grupal");

            migrationBuilder.DropTable(
                name: "catalogo_publicaciones_perfil_grupal");

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
