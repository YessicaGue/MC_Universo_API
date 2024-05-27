using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AddTablasCirculosCiudadanos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catalogo_check_ins_cedula_circulo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "varchar", maxLength: 250, nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    usuario_creacion_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_modificacion_id = table.Column<int>(type: "integer", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_check_ins_cedula_circulo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_estatus_circulo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "varchar", maxLength: 250, nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    usuario_creacion_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_modificacion_id = table.Column<int>(type: "integer", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_estatus_circulo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "perfil_invitacion_circulo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_anfitrion_id = table.Column<int>(type: "integer", nullable: false),
                    perfil_invitado_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    usuario_creacion_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_modificacion_id = table.Column<int>(type: "integer", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_invitacion_circulo", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_invitacion_circulo_perfil_perfil_anfitrion_id",
                        column: x => x.perfil_anfitrion_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_invitacion_circulo_perfil_perfil_invitado_id",
                        column: x => x.perfil_invitado_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tarea_circulo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_responsable_id = table.Column<int>(type: "integer", nullable: false),
                    nombre = table.Column<string>(type: "varchar", maxLength: 250, nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    fecha_compromiso = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    avance = table.Column<decimal>(type: "numeric", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    usuario_creacion_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_modificacion_id = table.Column<int>(type: "integer", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tarea_circulo", x => x.id);
                    table.ForeignKey(
                        name: "fk_tarea_circulo_perfil_perfil_responsable_id",
                        column: x => x.perfil_responsable_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historico_estatus_circulo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    estatus_anterior_id = table.Column<int>(type: "integer", nullable: false),
                    estatus_nuevo_id = table.Column<int>(type: "integer", nullable: false),
                    comentario_estatus = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    usuario_creacion_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_modificacion_id = table.Column<int>(type: "integer", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_historico_estatus_circulo", x => x.id);
                    table.ForeignKey(
                        name: "fk_historico_estatus_circulo_catalogo_estatus_circulo_estatus_",
                        column: x => x.estatus_anterior_id,
                        principalTable: "catalogo_estatus_circulo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_historico_estatus_circulo_catalogo_estatus_circulo_estatus_1",
                        column: x => x.estatus_nuevo_id,
                        principalTable: "catalogo_estatus_circulo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "circulo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_fundador_id = table.Column<int>(type: "integer", nullable: false, comment: "Id de perfil de quien crea el circulo"),
                    estatus_actual_historico_circulo_id = table.Column<int>(type: "integer", nullable: true),
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: false),
                    nombre = table.Column<string>(type: "varchar", maxLength: 250, nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    direccion = table.Column<string>(type: "text", nullable: true),
                    causa_prioritaria_uno = table.Column<string>(type: "text", nullable: true),
                    causa_prioritaria_dos = table.Column<string>(type: "text", nullable: true),
                    causa_prioritaria_tres = table.Column<string>(type: "text", nullable: true),
                    ruta_acta_constitutiva = table.Column<string>(type: "varchar", maxLength: 250, nullable: true),
                    guid_invitacion = table.Column<Guid>(type: "uuid", nullable: true),
                    liga_invitacion = table.Column<string>(type: "varchar", maxLength: 250, nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    usuario_creacion_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_modificacion_id = table.Column<int>(type: "integer", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_circulo", x => x.id);
                    table.ForeignKey(
                        name: "fk_circulo_entidad_federativa_entidad_federativa_id",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_circulo_historico_estatus_circulo_estatus_actual_historico_",
                        column: x => x.estatus_actual_historico_circulo_id,
                        principalTable: "historico_estatus_circulo",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_circulo_perfil_perfil_fundador_id",
                        column: x => x.perfil_fundador_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "perfil_circulo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    circulo_id = table.Column<int>(type: "integer", nullable: false),
                    ruta_cedula_registro = table.Column<string>(type: "varchar", maxLength: 250, nullable: true),
                    puede_generar_invitacion = table.Column<bool>(type: "boolean", nullable: false),
                    nombre = table.Column<string>(type: "varchar", maxLength: 250, nullable: false),
                    primer_apellido = table.Column<string>(type: "varchar", maxLength: 200, nullable: false),
                    segundo_apellido = table.Column<string>(type: "varchar", maxLength: 200, nullable: false),
                    fecha_nacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: true),
                    genero_id = table.Column<int>(type: "integer", nullable: true),
                    calle = table.Column<string>(type: "text", nullable: true),
                    no_exterior = table.Column<string>(type: "text", nullable: true),
                    no_interior = table.Column<string>(type: "text", nullable: true),
                    codigo_postal = table.Column<string>(type: "text", nullable: true),
                    colonia = table.Column<string>(type: "text", nullable: true),
                    municipio = table.Column<string>(type: "text", nullable: true),
                    celular = table.Column<string>(type: "text", nullable: true),
                    movil_sistema_operativo = table.Column<int>(type: "integer", nullable: false, comment: "MovilSO = 1: Android, 2: iOS, 3: Otro"),
                    telefono_fijo = table.Column<string>(type: "text", nullable: true),
                    cargo = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    liga_facebook = table.Column<string>(type: "text", nullable: true),
                    liga_twitter = table.Column<string>(type: "text", nullable: true),
                    clave_elector = table.Column<string>(type: "text", nullable: true),
                    clave_municipio = table.Column<string>(type: "text", nullable: true),
                    seccion_electoral = table.Column<string>(type: "text", nullable: true),
                    curp = table.Column<string>(type: "varchar", maxLength: 18, nullable: true),
                    localidad = table.Column<string>(type: "text", nullable: true),
                    firma = table.Column<string>(type: "text", nullable: true),
                    is_aviso_aceptado = table.Column<bool>(type: "boolean", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    usuario_creacion_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_modificacion_id = table.Column<int>(type: "integer", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_circulo", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_circulo_circulo_circulo_id",
                        column: x => x.circulo_id,
                        principalTable: "circulo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_circulo_entidad_federativa_entidad_federativa_id",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_perfil_circulo_genero_genero_id",
                        column: x => x.genero_id,
                        principalTable: "genero",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_perfil_circulo_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cedula_registro_check_ins",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_circulo_id = table.Column<int>(type: "integer", nullable: false),
                    check_in_id = table.Column<int>(type: "integer", nullable: false),
                    catalogo_check_ins_cedula_circulo_id = table.Column<int>(type: "integer", nullable: false),
                    is_accepted = table.Column<bool>(type: "boolean", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    usuario_creacion_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_modificacion_id = table.Column<int>(type: "integer", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cedula_registro_check_ins", x => x.id);
                    table.ForeignKey(
                        name: "fk_cedula_registro_check_ins_catalogo_check_ins_cedula_circulo",
                        column: x => x.catalogo_check_ins_cedula_circulo_id,
                        principalTable: "catalogo_check_ins_cedula_circulo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cedula_registro_check_ins_perfil_circulo_perfil_circulo_id",
                        column: x => x.perfil_circulo_id,
                        principalTable: "perfil_circulo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1705), "ltdte0hy" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1733), "6d5t8fo2" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1736), "1v0qdzce" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1740), "f2kslz5l" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1756), "udqvwps0" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1760), "7mvtjymm" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1763), "zhj8lylv" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.InsertData(
                table: "catalogo_check_ins_cedula_circulo",
                columns: new[] { "id", "activo", "fecha_creacion", "fecha_modificacion", "nombre", "usuario_creacion_id", "usuario_modificacion_id" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(3059), null, "Por mi libre voluntad solicito mi afiliación a Movimiento Ciudadano y apoyar las actividades que realicen.", 2, null },
                    { 2, true, new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(3067), null, "Me gustaría integrar un Círculo Ciudadano y apoyar con familiares, amigos y vecinos las actividades de Movimiento Ciudadano.", 2, null },
                    { 3, true, new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(3068), null, "Me gustaría recibir información de las actividades que realizan, simpatizo con Movimiento Ciudadano.", 2, null },
                    { 4, true, new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(3069), null, "Me gustaría ser candidato (a) ó representante de Movimiento Ciudadano.", 2, null }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9937), "8fjugkbc" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9984), "v05q19bw" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9987), "vrlqlcd3" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9991), "37jrrf8h" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(36), "san4t7q7" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2014), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2022), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2024), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.InsertData(
                table: "catalogo_estatus_circulo",
                columns: new[] { "id", "activo", "fecha_creacion", "fecha_modificacion", "nombre", "usuario_creacion_id", "usuario_modificacion_id" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2957), null, "En creación", 2, null },
                    { 2, true, new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2970), null, "Por validar", 2, null },
                    { 3, true, new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2971), null, "Validando", 2, null },
                    { 4, true, new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2972), null, "Validado", 2, null }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8837), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8852), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8854), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8857), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8858), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8860), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8862), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8863), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8865), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8867), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8869), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8870), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8872), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8873), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8875), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8876), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8878), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8880), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8882), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8886), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8888), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8889), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8891), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8892), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8894), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8895), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8896), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8898), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8899), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8901), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8902), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8904), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8905), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8908), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8909), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8911), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8913), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8914), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8915), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8917), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8918), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8920), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8923), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8924), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8926), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8928), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8929), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8930), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8932), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8933), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8935), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8936), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8937), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8948), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8950), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8952), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8953), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8955), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8957), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8958), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8960), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8961), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8965), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8967), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8969), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8972), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8973), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8975), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8977), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8978), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8980), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8981), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8983), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8985), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8986), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8988), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8989), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8991), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8992), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8994), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8996), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8997), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8999), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9000), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9002), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9004), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9005), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9007), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9011), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9012), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9014), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9016), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9018), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9019), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9021), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9022), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9024), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9032), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9033), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9035), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9036), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9037), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9038), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9040), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9041), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9043), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9044), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9046), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9047), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9048), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9050), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9051), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9052), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9054), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8048), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8062), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8064), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8065), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8066), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8068), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(122), "lyckoges" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(143), "6c9kp83s" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(147), "4ixceatl" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(151), "fr22ctsm" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(155), "61j41q87" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2102), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2196), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2206), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2208), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2282), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2291), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2747), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2759), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2760), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2761), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2762), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2765), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2766), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2767), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2769), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2660), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2670), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2671), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2672), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5859), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5876), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5878), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5879), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5881), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5883), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5884), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5885), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5886), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5888), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5889), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5921), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5923), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5924), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5925), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5926), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5928), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5929), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5931), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5932), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5933), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5934), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5935), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5937), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5938), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5939), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5942), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5943), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5944), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5945), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5946), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(6074), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(6502), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(3215), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.CreateIndex(
                name: "ix_cedula_registro_check_ins_catalogo_check_ins_cedula_circulo",
                table: "cedula_registro_check_ins",
                column: "catalogo_check_ins_cedula_circulo_id");

            migrationBuilder.CreateIndex(
                name: "ix_cedula_registro_check_ins_perfil_circulo_id",
                table: "cedula_registro_check_ins",
                column: "perfil_circulo_id");

            migrationBuilder.CreateIndex(
                name: "ix_circulo_entidad_federativa_id",
                table: "circulo",
                column: "entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_circulo_estatus_actual_historico_circulo_id",
                table: "circulo",
                column: "estatus_actual_historico_circulo_id");

            migrationBuilder.CreateIndex(
                name: "ix_circulo_perfil_fundador_id",
                table: "circulo",
                column: "perfil_fundador_id");

            migrationBuilder.CreateIndex(
                name: "ix_historico_estatus_circulo_estatus_anterior_id",
                table: "historico_estatus_circulo",
                column: "estatus_anterior_id");

            migrationBuilder.CreateIndex(
                name: "ix_historico_estatus_circulo_estatus_nuevo_id",
                table: "historico_estatus_circulo",
                column: "estatus_nuevo_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_circulo_circulo_id",
                table: "perfil_circulo",
                column: "circulo_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_circulo_entidad_federativa_id",
                table: "perfil_circulo",
                column: "entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_circulo_genero_id",
                table: "perfil_circulo",
                column: "genero_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_circulo_perfil_id",
                table: "perfil_circulo",
                column: "perfil_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_invitacion_circulo_perfil_anfitrion_id",
                table: "perfil_invitacion_circulo",
                column: "perfil_anfitrion_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_invitacion_circulo_perfil_invitado_id",
                table: "perfil_invitacion_circulo",
                column: "perfil_invitado_id");

            migrationBuilder.CreateIndex(
                name: "ix_tarea_circulo_perfil_responsable_id",
                table: "tarea_circulo",
                column: "perfil_responsable_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cedula_registro_check_ins");

            migrationBuilder.DropTable(
                name: "perfil_invitacion_circulo");

            migrationBuilder.DropTable(
                name: "tarea_circulo");

            migrationBuilder.DropTable(
                name: "catalogo_check_ins_cedula_circulo");

            migrationBuilder.DropTable(
                name: "perfil_circulo");

            migrationBuilder.DropTable(
                name: "circulo");

            migrationBuilder.DropTable(
                name: "historico_estatus_circulo");

            migrationBuilder.DropTable(
                name: "catalogo_estatus_circulo");

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
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6798), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6806), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6807), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6808), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6809), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6811), new DateTime(2024, 1, 12, 5, 29, 36, 285, DateTimeKind.Utc).AddTicks(6810) });

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
        }
    }
}
