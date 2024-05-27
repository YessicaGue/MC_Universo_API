using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaPerfilUsuarioAgregadaTablasCatalogoCHCCorregidas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catalogo_caminos_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    nombre_color = table.Column<string>(type: "text", nullable: true),
                    valor_color = table.Column<string>(type: "text", nullable: true, comment: "Valores en HEX"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_caminos_chc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_documentos_eligibilidad_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false, comment: "Nombre corto"),
                    descripcion = table.Column<string>(type: "text", nullable: true, comment: "Es importante tener una descripcion detallada sobre lo que trata y sobre la manera de entregar"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_documentos_eligibilidad_chc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_estatus_documentos_eligibilidad_chc",
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
                    table.PrimaryKey("pk_catalogo_estatus_documentos_eligibilidad_chc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_niveles_cargos",
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
                    table.PrimaryKey("pk_catalogo_niveles_cargos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_tipos_etapas_chc",
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
                    table.PrimaryKey("pk_catalogo_tipos_etapas_chc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_tipos_preguntas",
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
                    table.PrimaryKey("pk_catalogo_tipos_preguntas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "perfil_usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    email_verified_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    password = table.Column<string>(type: "text", nullable: false),
                    area = table.Column<string>(type: "text", nullable: true),
                    puesto = table.Column<string>(type: "text", nullable: true),
                    profile_image = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_usuario", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_usuario_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_cargos_postulacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nivel_cargo_id = table.Column<int>(type: "integer", nullable: false),
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: true),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_cargos_postulacion", x => x.id);
                    table.ForeignKey(
                        name: "fk_catalogo_cargos_postulacion_catalogo_niveles_cargos_nivel_c",
                        column: x => x.nivel_cargo_id,
                        principalTable: "catalogo_niveles_cargos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_catalogo_cargos_postulacion_entidad_federativa_entidad_fede",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "catalogo_etapas_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    camino_id = table.Column<int>(type: "integer", nullable: false),
                    tipo_etapa_id = table.Column<int>(type: "integer", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    fecha_limite = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Fecha en la que la etapa va a terminar"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_etapas_chc", x => x.id);
                    table.ForeignKey(
                        name: "fk_catalogo_etapas_chc_catalogo_caminos_chc_camino_id",
                        column: x => x.camino_id,
                        principalTable: "catalogo_caminos_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_catalogo_etapas_chc_catalogo_tipos_etapas_chc_tipo_etapa_id",
                        column: x => x.tipo_etapa_id,
                        principalTable: "catalogo_tipos_etapas_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.InsertData(
                table: "catalogo_caminos_chc",
                columns: new[] { "id", "activo", "descripcion", "fecha_creacion", "nombre", "nombre_color", "valor_color" },
                values: new object[,]
                {
                    { 1, true, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1879), "General", "Naranja", null },
                    { 2, true, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1890), "Mujeres", "Violeta", null },
                    { 3, true, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1891), "Jóvenes", "Fosfo", null },
                    { 4, true, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1892), "Ciudadano", "Blanco", null },
                    { 5, true, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1893), "Personas con discapacidad", "Eléctrico", null },
                    { 6, true, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1894), "Pueblos originarios", "Celeste", null },
                    { 7, true, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1895), "Afrodescendientes", "Limón", null },
                    { 8, true, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1895), "LGBTTTIQ", "Arcoíris", null },
                    { 9, true, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1896), "Combinado", "Tornasol", null }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.InsertData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1946), "Por validar" },
                    { 2, true, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1954), "Rechazado" },
                    { 3, true, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1955), "En revisión" },
                    { 4, true, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1956), "Aceptado" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1436));

            migrationBuilder.InsertData(
                table: "catalogo_tipos_etapas_chc",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2371), "Camino al Heroe Ciudadano" },
                    { 2, true, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2376), "Camino al Candidat@" }
                });

            migrationBuilder.InsertData(
                table: "catalogo_tipos_preguntas",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2420), "Opción múltiple" },
                    { 2, true, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2425), "Boleano" },
                    { 3, true, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2426), "Selección única" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9960), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9969), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9970), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9971), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9972), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9974), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9976), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9977), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9978), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9979), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9980), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9988), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9989), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9990), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9992), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9993), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9994), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9996), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9998), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(8), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(9), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(11), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(12), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(13), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(14), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(15), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(16), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(17), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(68), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(367), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(8148), new DateTime(2023, 7, 31, 22, 49, 56, 783, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.InsertData(
                table: "catalogo_etapas_chc",
                columns: new[] { "id", "activo", "camino_id", "descripcion", "fecha_creacion", "fecha_limite", "nombre", "tipo_etapa_id" },
                values: new object[,]
                {
                    { 1, true, 1, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2021), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2021), "Nivel 0", 1 },
                    { 2, true, 1, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2028), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2028), "Requisitos de elegibilidad", 1 },
                    { 3, true, 1, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2029), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2029), "Capacitación básica", 1 },
                    { 4, true, 1, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2030), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2030), "Crea tu equipo", 1 },
                    { 5, true, 1, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2032), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2031), "Tu causa", 1 },
                    { 6, true, 1, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2033), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2033), "Agenda ciudadana", 1 },
                    { 7, true, 1, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2034), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2034), "3 de 3", 1 },
                    { 8, true, 1, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2036), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2035), "Ficha territorial", 1 },
                    { 9, true, 1, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2037), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2037), "Estrategia política", 2 },
                    { 10, true, 1, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2038), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2038), "Agenda de trabajo", 2 },
                    { 11, true, 1, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2040), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2039), "Ficha y equipo electoral", 2 },
                    { 12, true, 1, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2041), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2041), "Perfil del ciudadano", 2 },
                    { 13, true, 2, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2042), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2042), "Nivel 0", 1 },
                    { 14, true, 2, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2043), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2043), "Requisitos de elegibilidad", 1 },
                    { 15, true, 2, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2045), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2044), "Capacitación básica", 1 },
                    { 16, true, 2, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2046), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2045), "Crea tu equipo", 1 },
                    { 17, true, 2, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2047), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2047), "Tu causa", 1 },
                    { 18, true, 2, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2048), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2048), "Agenda ciudadana", 1 },
                    { 19, true, 2, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2050), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2049), "3 de 3", 1 },
                    { 20, true, 2, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2051), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2050), "Ficha territorial", 1 },
                    { 21, true, 2, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2052), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2052), "Estrategia política", 2 },
                    { 22, true, 2, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2053), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2053), "Agenda de trabajo", 2 },
                    { 23, true, 2, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2054), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2054), "Ficha y equipo electoral", 2 },
                    { 24, true, 2, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2055), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2055), "Perfil del ciudadano", 2 },
                    { 25, true, 3, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2057), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2056), "Nivel 0", 1 },
                    { 26, true, 3, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2058), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2057), "Requisitos de elegibilidad", 1 },
                    { 27, true, 3, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2059), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2059), "Capacitación básica", 1 },
                    { 28, true, 3, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2060), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2060), "Crea tu equipo", 1 },
                    { 29, true, 3, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2061), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2061), "Tu causa", 1 },
                    { 30, true, 3, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2062), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2062), "Agenda ciudadana", 1 },
                    { 31, true, 3, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2063), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2063), "3 de 3", 1 },
                    { 32, true, 3, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2065), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2064), "Ficha territorial", 1 },
                    { 33, true, 3, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2066), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2065), "Estrategia política", 2 },
                    { 34, true, 3, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2067), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2067), "Agenda de trabajo", 2 },
                    { 35, true, 3, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2069), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2068), "Ficha y equipo electoral", 2 },
                    { 36, true, 3, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2070), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2069), "Perfil del ciudadano", 2 },
                    { 37, true, 4, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2071), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2071), "Requisitos de elegibilidad", 1 },
                    { 38, true, 4, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2072), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2072), "Capacitación básica", 1 },
                    { 39, true, 4, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2073), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2073), "3 de 3", 1 },
                    { 40, true, 4, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2074), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2074), "Tu causa", 1 },
                    { 41, true, 4, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2075), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2075), "Tu causa", 1 },
                    { 42, true, 4, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2077), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2076), "Agenda ciudadana", 1 },
                    { 43, true, 4, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2078), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2077), "Firmas", 1 },
                    { 44, true, 4, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2079), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2079), "Ficha territorial", 1 },
                    { 45, true, 4, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2080), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2080), "Estrategia política", 2 },
                    { 46, true, 4, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2081), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2081), "Agenda de trabajo", 2 },
                    { 47, true, 4, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2115), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2115), "Ficha y equipo electoral", 2 },
                    { 48, true, 4, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2116), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2116), "Perfil del ciudadano", 2 },
                    { 49, true, 5, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2118), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2117), "Requisitos de elegibilidad", 1 },
                    { 50, true, 5, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2119), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2119), "Capacitación básica", 1 },
                    { 51, true, 5, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2120), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2120), "Crea tu equipo", 1 },
                    { 52, true, 5, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2121), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2121), "Tu causa", 1 },
                    { 53, true, 5, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2122), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2122), "Agenda ciudadana", 1 },
                    { 54, true, 5, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2124), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2123), "3 de 3", 1 },
                    { 55, true, 5, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2125), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2124), "Firmas", 1 },
                    { 56, true, 5, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2126), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2126), "Ficha territorial", 1 },
                    { 57, true, 5, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2127), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2127), "Estrategia política", 2 },
                    { 58, true, 5, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2128), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2128), "Agenda de trabajo", 2 },
                    { 59, true, 5, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2129), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2129), "Ficha y equipo electoral", 2 },
                    { 60, true, 5, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2130), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2130), "Perfil del ciudadano", 2 },
                    { 61, true, 6, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2132), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2131), "Requisitos de elegibilidad", 1 },
                    { 62, true, 6, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2133), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2132), "Capacitación básica", 1 },
                    { 63, true, 6, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2134), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2134), "Crea tu equipo", 1 },
                    { 64, true, 6, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2135), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2135), "Tu causa", 1 },
                    { 65, true, 6, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2136), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2136), "Agenda ciudadana", 1 },
                    { 66, true, 6, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2138), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2138), "3 de 3", 1 },
                    { 67, true, 6, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2139), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2139), "Firmas", 1 },
                    { 68, true, 6, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2140), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2140), "Ficha territorial", 1 },
                    { 69, true, 6, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2141), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2141), "Estrategia política", 2 },
                    { 70, true, 6, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2143), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2142), "Agenda de trabajo", 2 },
                    { 71, true, 6, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2144), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2144), "Ficha y equipo electoral", 2 },
                    { 72, true, 6, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2145), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2145), "Perfil del ciudadano", 2 },
                    { 73, true, 7, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2146), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2146), "Requisitos de elegibilidad", 1 },
                    { 74, true, 7, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2147), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2147), "Capacitación básica", 1 },
                    { 75, true, 7, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2148), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2148), "Crea tu equipo", 1 },
                    { 76, true, 7, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2149), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2149), "Tu causa", 1 },
                    { 77, true, 7, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2151), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2150), "Agenda ciudadana", 1 },
                    { 78, true, 7, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2152), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2151), "3 de 3", 1 },
                    { 79, true, 7, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2153), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2153), "Firmas", 1 },
                    { 80, true, 7, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2154), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2154), "Ficha territorial", 1 },
                    { 81, true, 7, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2155), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2155), "Estrategia política", 2 },
                    { 82, true, 7, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2156), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2156), "Agenda de trabajo", 2 },
                    { 83, true, 7, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2157), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2157), "Ficha y equipo electoral", 2 },
                    { 84, true, 7, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2159), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2158), "Perfil del ciudadano", 2 },
                    { 85, true, 8, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2160), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2159), "Requisitos de elegibilidad", 1 },
                    { 86, true, 8, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2161), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2160), "Capacitación básica", 1 },
                    { 87, true, 8, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2162), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2162), "Crea tu equipo", 1 },
                    { 88, true, 8, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2163), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2163), "Tu causa", 1 },
                    { 89, true, 8, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2164), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2164), "Agenda ciudadana", 1 },
                    { 90, true, 8, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2165), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2165), "3 de 3", 1 },
                    { 91, true, 8, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2166), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2166), "Firmas", 1 },
                    { 92, true, 8, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2168), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2167), "Ficha territorial", 1 },
                    { 93, true, 8, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2169), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2168), "Estrategia política", 2 },
                    { 94, true, 8, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2170), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2169), "Agenda de trabajo", 2 },
                    { 95, true, 8, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2171), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2171), "Ficha y equipo electoral", 2 },
                    { 96, true, 8, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2172), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2172), "Perfil del ciudadano", 2 },
                    { 97, true, 9, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2173), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2173), "Requisitos de elegibilidad", 1 },
                    { 98, true, 9, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2174), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2174), "Capacitación básica", 1 },
                    { 99, true, 9, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2175), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2175), "Crea tu equipo", 1 },
                    { 100, true, 9, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2177), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2176), "Tu causa", 1 },
                    { 101, true, 9, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2178), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2177), "Agenda ciudadana", 1 },
                    { 102, true, 9, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2179), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2179), "3 de 3", 1 },
                    { 103, true, 9, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2180), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2180), "Firmas", 1 },
                    { 104, true, 9, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2181), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2181), "Ficha territorial", 1 },
                    { 105, true, 9, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2182), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2182), "Estrategia política", 2 },
                    { 106, true, 9, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2183), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2183), "Agenda de trabajo", 2 },
                    { 107, true, 9, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2184), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2184), "Ficha y equipo electoral", 2 },
                    { 108, true, 9, null, new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2186), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2185), "Perfil del ciudadano", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_catalogo_cargos_postulacion_entidad_federativa_id",
                table: "catalogo_cargos_postulacion",
                column: "entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_catalogo_cargos_postulacion_nivel_cargo_id",
                table: "catalogo_cargos_postulacion",
                column: "nivel_cargo_id");

            migrationBuilder.CreateIndex(
                name: "ix_catalogo_etapas_chc_camino_id",
                table: "catalogo_etapas_chc",
                column: "camino_id");

            migrationBuilder.CreateIndex(
                name: "ix_catalogo_etapas_chc_tipo_etapa_id",
                table: "catalogo_etapas_chc",
                column: "tipo_etapa_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_usuario_perfil_id",
                table: "perfil_usuario",
                column: "perfil_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catalogo_cargos_postulacion");

            migrationBuilder.DropTable(
                name: "catalogo_documentos_eligibilidad_chc");

            migrationBuilder.DropTable(
                name: "catalogo_estatus_documentos_eligibilidad_chc");

            migrationBuilder.DropTable(
                name: "catalogo_etapas_chc");

            migrationBuilder.DropTable(
                name: "catalogo_tipos_preguntas");

            migrationBuilder.DropTable(
                name: "perfil_usuario");

            migrationBuilder.DropTable(
                name: "catalogo_niveles_cargos");

            migrationBuilder.DropTable(
                name: "catalogo_caminos_chc");

            migrationBuilder.DropTable(
                name: "catalogo_tipos_etapas_chc");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8297), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8302), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8303), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8304), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8305), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8307), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8308), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8309), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8310), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8312), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8313), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8314), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8315), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8316), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8317), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8318), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8319), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8321), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8322), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8323), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8324), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8325), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8326), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8327), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8328), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8329), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8330), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8331), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8333), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8334), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8335), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8336), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8373), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8586), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(6925), new DateTime(2023, 7, 31, 17, 56, 37, 497, DateTimeKind.Utc).AddTicks(6928) });
        }
    }
}
